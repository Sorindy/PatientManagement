using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hospital_Entity_Framework;

namespace PatientManagement.Class
{
    public class ConsultationStatus : IStatus
    {
        private HospitalDbContext _db = new HospitalDbContext();

        public void Insert(string id, bool status)
        {
            var insert = new ConsultationStatu() { ConsultationId = id, Status = status };

            _db.ConsultationStatus.Add(insert);
            _db.SaveChanges();
        }

        public void Update(string id, bool status)
        {
            var update = _db.ConsultationStatus.Single(v => v.ConsultationId == id);
            update.Status = status;

            _db.ConsultationStatus.AddOrUpdate(update);
            _db.SaveChanges();
        }

        public void Delete(string id)
        {
            var delete = _db.ConsultationStatus.Single(v => v.ConsultationId == id);

            _db.ConsultationStatus.Remove(delete);
            _db.SaveChanges();
        }

        public string AutoId()
        {
            Hospital_Entity_Framework.ConsultationStatu consultationStatu = new Hospital_Entity_Framework.ConsultationStatu();
            try
            {
                var getLastId = _db.ConsultationStatus.OrderByDescending(v => v.ConsultationId).First();
                var getvalue = getLastId.ConsultationId.ToString();
                var num = Convert.ToInt32(getvalue.Substring(18));
                num += 1;
                consultationStatu.ConsultationId = string.Concat("ConsultationStatus", num);
            }
            catch
            {
                consultationStatu.ConsultationId = "ConsultationStatus1";
            }
            return consultationStatu.ConsultationId;
        }

        public TreeNode ShowCategory()
        {
            TreeNode treeNode = new TreeNode();
            treeNode.Text = @"Consultation";

            var getCategory = from v in _db.ConsultationCategories
                select new { v.Name };

            foreach (var item in getCategory)
            {
                treeNode.Nodes.Add(item.Name);
            }
            return treeNode;
        }
        public GroupBox ShowCategoryBox()
        {
            var checkListBox = new CheckedListBox();
            var groupBox = new GroupBox();
            var checkBox = new CheckBox();
            var flpn = new FlowLayoutPanel()
            {
                FlowDirection = FlowDirection.TopDown,
                Dock = DockStyle.Fill
            };
            flpn.Size = new Size(508, 54);
            flpn.AutoScroll = true;
            groupBox.Size = new Size(520, 100);
            checkListBox.Size = new Size(508, 54);

            groupBox.Text = @"Consutation";
            var getCategroy = from v in _db.ConsultationCategories select new { v.Name };
            foreach (var item in getCategroy)
            {
                checkListBox.Items.Add(item.Name);
            }

            flpn.Controls.Add(checkListBox);
            groupBox.Controls.Add(flpn);
            return groupBox;
        }

    }
}
