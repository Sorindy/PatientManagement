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
    class ConsultationCategoryStatus:ICategoryStatus
    {
        private HospitalDbContext _db=new HospitalDbContext();

        public string AutoId()
        {
            var catStatusId=new ConsultationCategoryStatu();

            try
            {
                var getLastId = _db.ConsultationCategoryStatus.OrderByDescending(m => m.Consult_CategoryId).First();
                var getvalue = getLastId.Consult_CategoryId;
                var num = Convert.ToInt32(getvalue.Substring(12));
                num += 1;
                catStatusId.Consult_CategoryId = string.Concat("ConCatStatus", num);
            }
            catch
            {
                catStatusId.Consult_CategoryId = "ConCatStatus1";
            }

            return catStatusId.Consult_CategoryId;
        }

        public void Insert(string id, string catid, bool status)
        {
            var insert=new ConsultationCategoryStatu(){Consult_CategoryId = id,CategoryId = catid,Status = status};

            _db.ConsultationCategoryStatus.Add(insert);
            _db.SaveChanges();
        }

        public void Delete(string id)
        {
            var delete = _db.ConsultationCategoryStatus.Single(v => v.Consult_CategoryId == id);

            _db.ConsultationCategoryStatus.Remove(delete);
            _db.SaveChanges();
        }

        public void Update(string id, string catid, bool status)
        {
            var update = _db.ConsultationCategoryStatus.Single(v => v.Consult_CategoryId == id);
            update.CategoryId = catid;
            update.Status = status;

            _db.ConsultationCategoryStatus.AddOrUpdate(update);
            _db.SaveChanges();
        }
    }
}
