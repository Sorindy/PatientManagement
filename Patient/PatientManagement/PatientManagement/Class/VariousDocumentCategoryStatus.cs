using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hospital_Entity_Framework;
using PatientManagement.Interface;

namespace PatientManagement.Class
{
    class VariousDocumentCategoryStatus : ICategoryStatus
    {
        private HospitalDbContext _db = new HospitalDbContext();

        public string AutoId()
        {
            var catStatusId = new VariousDocumentCategoryStatu();

            try
            {
                var getLastId = _db.VariousDocumentCategoryStatus.OrderByDescending(m => m.VariousDocument_CategoryId).First();
                var getvalue = getLastId.VariousDocument_CategoryId;
                var num = Convert.ToInt32(getvalue.Substring(12));
                num += 1;
                catStatusId.VariousDocument_CategoryId = string.Concat("VarCatStatus", num);
            }
            catch
            {
                catStatusId.VariousDocument_CategoryId = "VarCatStatus1";
            }

            return catStatusId.VariousDocument_CategoryId;
        }

        public void Insert(string id, string catid, bool status)
        {
            var insert = new VariousDocumentCategoryStatu() { VariousDocument_CategoryId = id, CategoryId = catid, Status = status };

            _db.VariousDocumentCategoryStatus.Add(insert);
            _db.SaveChanges();
        }

        public void Delete(string id)
        {
            var delete = _db.VariousDocumentCategoryStatus.Single(v => v.VariousDocument_CategoryId == id);

            _db.VariousDocumentCategoryStatus.Remove(delete);
            _db.SaveChanges();
        }

        public void Update(string id, string catid, bool status)
        {
            var update = _db.PrescriptionCategoryStatus.Single(v => v.Prescription_CategoryId == id);
            update.CategoryId = catid;
            update.Status = status;

            _db.PrescriptionCategoryStatus.AddOrUpdate(update);
            _db.SaveChanges();
        }
    }
}
