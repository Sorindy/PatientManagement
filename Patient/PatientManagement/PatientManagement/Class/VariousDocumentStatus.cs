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
    class VariousDocumentStatus:IStatus
    {
        private HospitalDbContext _db=new HospitalDbContext();
        public void Insert(string id, bool status)
        {
            var insert=new VariousDocumentStatu(){VariousDocumentId = id,Status =status};

            _db.VariousDocumentStatus.Add(insert);
            _db.SaveChanges();
        }

        public void Update(string id, bool status)
        {
            var update = _db.VariousDocumentStatus.Single(v => v.VariousDocumentId == id);
            update.Status = status;

            _db.VariousDocumentStatus.AddOrUpdate(update);
            _db.SaveChanges();
        }

        public void Delete(string id)
        {
            var delete = _db.VariousDocumentStatus.Single(v => v.VariousDocumentId == id);

            _db.VariousDocumentStatus.Remove(delete);
            _db.SaveChanges();
        }

        public string AutoId()
        {
            VariousDocumentStatu various=new VariousDocumentStatu();
            try
            {
                var getLastId = _db.VariousDocumentStatus.OrderByDescending(v => v.VariousDocumentId).First();
                var getvalue = getLastId.VariousDocumentId.ToString();
                var num = Convert.ToInt32(getvalue.Substring(21));
                num += 1;
                various.VariousDocumentId = string.Concat("VariousDocumentStatus", num);
            }
            catch
            {
                various.VariousDocumentId = "VariousDocumentStatus1";
            }
            return various.VariousDocumentId;
        }

        public TreeNode ShowCategory()
        {
            TreeNode treeNode = new TreeNode();
            treeNode.Text = "VariousDocument";

                var getCategory = from v in _db.VariousDocumentCategories
                    select new { v.Name };

                foreach (var item in getCategory)
                {
                    treeNode.Nodes.Add(item.Name);
                }

            return treeNode;
        }
    }
}
