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
    class MedicalImagingCategoryStatus : ICategoryStatus
    {
        private HospitalDbContext _db = new HospitalDbContext();

        public string AutoId()
        {
            var catStatusId = new MedicalImagingCategoryStatu();

            try
            {
                var getLastId = _db.MedicalImagingCategoryStatus.OrderByDescending(m => m.MedImaging_CategoryId).First();
                var getvalue = getLastId.MedImaging_CategoryId;
                var num = Convert.ToInt32(getvalue.Substring(12));
                num += 1;
                catStatusId.MedImaging_CategoryId = string.Concat("MedCatStatus", num);
            }
            catch
            {
                catStatusId.MedImaging_CategoryId = "MedCatStatus1";
            }

            return catStatusId.MedImaging_CategoryId;
        }

        public void Insert(string id, string catid, bool status)
        {
            var insert = new MedicalImagingCategoryStatu(){ MedImaging_CategoryId = id, CategoryId = catid, Status = status };

            _db.MedicalImagingCategoryStatus.Add(insert);
            _db.SaveChanges();
        }

        public void Delete(string id)
        {
            var delete = _db.MedicalImagingCategoryStatus.Single(v => v.MedImaging_CategoryId == id);

            _db.MedicalImagingCategoryStatus.Remove(delete);
            _db.SaveChanges();
        }

        public void Update(string id, string catid, bool status)
        {
            var update = _db.MedicalImagingCategoryStatus.Single(v => v.MedImaging_CategoryId == id);
            update.CategoryId = catid;
            update.Status = status;

            _db.MedicalImagingCategoryStatus.AddOrUpdate(update);
            _db.SaveChanges();
        }
    }
}
