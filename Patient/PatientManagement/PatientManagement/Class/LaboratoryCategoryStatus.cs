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
    class LaboratoryCategoryStatus:ICategoryStatus
    {
        private HospitalDbContext _db = new HospitalDbContext();

        public string AutoId()
        {
            var catStatusId = new LaboratoryCategoryStatu();

            try
            {
                var getLastId = _db.LaboratoryCategoryStatus.OrderByDescending(m => m.Laboratory_CategoryId).First();
                var getvalue = getLastId.Laboratory_CategoryId;
                var num = Convert.ToInt32(getvalue.Substring(12));
                num += 1;
                catStatusId.Laboratory_CategoryId = string.Concat("LabCatStatus", num);
            }
            catch
            {
                catStatusId.Laboratory_CategoryId = "LabCatStatus1";
            }

            return catStatusId.Laboratory_CategoryId;
        }

        public void Insert(string id, string catid, bool status)
        {
            var insert = new LaboratoryCategoryStatu() { Laboratory_CategoryId = id, CategoryId = catid, Status = status };

            _db.LaboratoryCategoryStatus.Add(insert);
            _db.SaveChanges();
        }

        public void Delete(string id)
        {
            var delete = _db.LaboratoryCategoryStatus.Single(v => v.Laboratory_CategoryId == id);

            _db.LaboratoryCategoryStatus.Remove(delete);
            _db.SaveChanges();
        }

        public void Update(string id, string catid, bool status)
        {
            var update = _db.LaboratoryCategoryStatus.Single(v => v.Laboratory_CategoryId == id);
            update.CategoryId = catid;
            update.Status = status;

            _db.LaboratoryCategoryStatus.AddOrUpdate(update);
            _db.SaveChanges();
        }
    }
}
