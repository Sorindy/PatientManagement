using System;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Windows.Forms;
using Hospital_Entity_Framework;
using PatientManagement.Interface;

namespace PatientManagement.Class
{
   public  class MedicalImagingHistory:IHistory
    {
        private readonly HospitalDbContext _db = new HospitalDbContext();

        public void Update(int estimateId, int workerId, int? nurseId, int? refererId)
        {
            var update = _db.MedicalImagingEstimates.First(v => v.Id == estimateId);
            update.WorkerId = workerId;
            update.NurseId = nurseId;
            update.ReferrerId = refererId;
            update.Date = DateTime.Today;
            update.Edit = true;

            _db.MedicalImagingEstimates.AddOrUpdate(update);
            _db.SaveChanges();
        }

        public object Show(int patientId,int categoryId)
        {
            var getEstimate = from v in _db.MedicalImagingEstimates
                where v.PatientId == patientId && v.CategoryId == categoryId
                select new
                {
                    v.Id,
                    v.Date,
                    Doctor = v.Worker.LastName,
                    Nurse = v.Worker1.LastName ,
                    Referrer = v.Referrer.LastName ,
                    Category = v.MedicalImagingCategory.Name,
                    v.Edit
                };
            var bs = new BindingSource { DataSource = getEstimate.ToList() };

            return bs;
        }
        public string GetPath(int estimateId)
        {
            var get = _db.MedicalImagingEstimates.First(v => v.Id == estimateId).Description;
            return get;
        }
    }
}
