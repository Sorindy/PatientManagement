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
    class PrescriptionCategoryStatus:ICategoryStatus
    {
        private HospitalDbContext _db = new HospitalDbContext();

        public string AutoId()
        {
            var catStatusId = new PrescriptionCategoryStatu();

            try
            {
                var getLastId = _db.PrescriptionCategoryStatus.OrderByDescending(m => m.Prescription_CategoryId).First();
                var getvalue = getLastId.Prescription_CategoryId;
                var num = Convert.ToInt32(getvalue.Substring(12));
                num += 1;
                catStatusId.Prescription_CategoryId = string.Concat("PreCatStatus", num);
            }
            catch
            {
                catStatusId.Prescription_CategoryId = "PreCatStatus1";
            }

            return catStatusId.Prescription_CategoryId;
        }

        public void Insert(string id, string catid, bool status)
        {
            var insert = new PrescriptionCategoryStatu() { Prescription_CategoryId = id, CategoryId = catid, Status = status };

            _db.PrescriptionCategoryStatus.Add(insert);
            _db.SaveChanges();
        }

        public void Delete(string id)
        {
            var delete = _db.PrescriptionCategoryStatus.Single(v => v.Prescription_CategoryId == id);

            _db.PrescriptionCategoryStatus.Remove(delete);
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
