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
    public class MedicalImagingStatus : IStatus
    {
        private HospitalDbContext _db = new HospitalDbContext();

        public void Insert(string id, bool status)
        {
            var insert = new MedicalImagingStatu() { MedicalImagingId = id, Status = status };

            _db.MedicalImagingStatus.Add(insert);
            _db.SaveChanges();
        }

        public void Update(string id, bool status)
        {
            var update = _db.MedicalImagingStatus.Single(v => v.MedicalImagingId == id);
            update.Status = status;

            _db.MedicalImagingStatus.AddOrUpdate(update);
            _db.SaveChanges();
        }

        public void Delete(string id)
        {
            var delete = _db.MedicalImagingStatus.Single(v => v.MedicalImagingId == id);

            _db.MedicalImagingStatus.Remove(delete);
            _db.SaveChanges();
        }

        public string AutoId()
        {
            MedicalImagingStatu medical = new MedicalImagingStatu();
            try
            {
                var getLastId = _db.MedicalImagingStatus.OrderByDescending(v => v.MedicalImagingId).First();
                var getvalue = getLastId.MedicalImagingId.ToString();
                var num = Convert.ToInt32(getvalue.Substring(20));
                num += 1;
                medical.MedicalImagingId = string.Concat("MedicalImagingStatus", num);
            }
            catch
            {
                medical.MedicalImagingId = "MedicalImagingStatus1";
            }
            return medical.MedicalImagingId;
        }

        public TreeNode ShowCategory()
        {
            TreeNode treeNode = new TreeNode();
            treeNode.Text = "MedicalImaging";

            var getCategory = from v in _db.MedicalImagingCategories
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

            groupBox.Text = @"MedicalImaging";
            var getCategroy = from v in _db.MedicalImagingCategories select new { v.Name };
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
