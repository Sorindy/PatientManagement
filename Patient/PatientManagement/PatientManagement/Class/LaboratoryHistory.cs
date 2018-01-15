using System;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Windows.Forms;
using Hospital_Entity_Framework;
using PatientManagement.Interface;

namespace PatientManagement.Class
{
   public  class LaboratoryHistory:IHistory
    {
        private readonly HospitalDbContext _db = new HospitalDbContext();

        public void Update(int estimateId, int workerId, int? nurseId, int? refererId)
        {
            var update = _db.LaboratoryEstimates.First(v => v.Id == estimateId);
            update.WorkerId = workerId;
            update.NurseId = nurseId;
            update.ReferrerId = refererId;
            update.Date = DateTime.Today;
            update.Edit = true;

            _db.LaboratoryEstimates.AddOrUpdate(update);
            _db.SaveChanges();
        }

        public object Show(int patientId,int categoryId)
        {
            var getEstimate = from v in _db.LaboratoryEstimates
                where v.PatientId == patientId && v.CategoryId == categoryId
                select new
                {
                    v.Id,
                    v.Date,
                    Doctor = v.Worker.LastName ,
                    Nurse = v.Worker1.LastName ,
                    Referrer = v.Referrer.LastName ,
                    Category = v.LaboratoryCategory.Name,
                    v.Edit
                };
            var bs = new BindingSource { DataSource = getEstimate.ToList() };

            return bs;
        }
        public string GetPath(int estimateId)
        {
            var get = _db.LaboratoryEstimates.First(v => v.Id == estimateId).Description;
            return get;
        }

        public bool CheckDoctorCategory(int workerid, int categoryid)
        {
            var check = _db.Managements.First(v => v.Account.WorkerId == workerid).LaboratoryCategories
                .Any(v => v.Id == categoryid);
            return check;

        }
    }
}
