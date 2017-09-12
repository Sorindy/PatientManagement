using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hospital_Entity_Framework;

namespace PatientManagement.Class
{
    public class PrescriptionStatus:IStatus
    {
        private HospitalDbContext _db=new HospitalDbContext();

        public void Insert(string id, bool status)
        {
            var insert=new PrescriptionStatu(){PrescriptionId = id,Status = status};

            _db.PrescriptionStatus.Add(insert);
            _db.SaveChanges();
        }

        public void Update(string id, bool status)
        {
            var update=_db.PrescriptionStatus.Single(v=>v.PrescriptionId==id);
            update.Status = status;

            _db.PrescriptionStatus.AddOrUpdate(update);
            _db.SaveChanges();
        }

        public void Delete(string id)
        {
            var delete = _db.PrescriptionStatus.Single(v => v.PrescriptionId == id);

            _db.PrescriptionStatus.Remove(delete);
            _db.SaveChanges();
        }

        public string AutoId()
        {
            PrescriptionStatu prescription=new PrescriptionStatu();
            try
            {
                var getLastId = _db.PrescriptionStatus.OrderByDescending(v => v.PrescriptionId).First();
                var getvalue = getLastId.PrescriptionId.ToString();
                var num = Convert.ToInt32(getvalue.Substring(18));
                num += 1;
                prescription.PrescriptionId = string.Concat("PrescriptionStatus", num);
            }
            catch
            {
                prescription.PrescriptionId = "PrescriptionStatus1";
            }
            return prescription.PrescriptionId;
        }

        public TreeNode ShowCategory()
        {
            TreeNode treeNode = new TreeNode();
            treeNode.Text = "Prescription";

                var getCategory = from v in _db.PrescriptionCategories
                    select new { v.Name };

                foreach (var item in getCategory)
                {
                    treeNode.Nodes.Add(item.Name);
                }
          
            return treeNode;
        }
    }
}
