using System;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Windows.Forms;
using Hospital_Entity_Framework;

namespace PatientManagement.Class
{
    public class LaboratoryStatus:IStatus
    {
        private readonly HospitalDbContext _db=new HospitalDbContext();

        public void Insert(string id, bool status)
        {
            var insert=new LaboratoryStatu(){LaboratoryId = id,Status = status};

            _db.LaboratoryStatus.Add(insert);
            _db.SaveChanges();
        }

        public void Update(string id, bool status)
        {
            var update = _db.LaboratoryStatus.Single(v => v.LaboratoryId == id);
            update.Status = status;

            _db.LaboratoryStatus.AddOrUpdate(update);
            _db.SaveChanges();
        }

        public void Delete(string id)
        {
            var delete = _db.LaboratoryStatus.Single(v => v.LaboratoryId == id);

            _db.LaboratoryStatus.Remove(delete);
            _db.SaveChanges();
        }

        public string AutoId()
        {
            var statu=new LaboratoryStatu();
            try
            {
                var getLastId = _db.LaboratoryStatus.OrderByDescending(v => v.LaboratoryId).First();
                var getvalue = getLastId.LaboratoryId;
                var num = Convert.ToInt32(getvalue.Substring(16));
                num += 1;
                statu.LaboratoryId = string.Concat("LaboratoryStatus", num);
            }
            catch
            {
                statu.LaboratoryId = "LaboratoryStatus1";
            }
            return statu.LaboratoryId;
        }

        public TreeNode ShowCategory()
        {
            var treeNode = new TreeNode {Text = @"Laboratory"};

            var getLaboratoryStatus = from v in _db.LaboratoryCategories
                    select new
                    {
                        v.Name
                    };

                foreach (var itemLaboratoryStatu in getLaboratoryStatus)
                {
                    treeNode.Nodes.Add(itemLaboratoryStatu.Name);
                }

            return treeNode;
        }
    }
}
