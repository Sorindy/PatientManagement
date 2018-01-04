using System;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Windows.Forms;
using Hospital_Entity_Framework;
using PatientManagement.Interface;

namespace PatientManagement.Class
{
   public  class VariousDocumentHistory:IHistory
    {
        private readonly HospitalDbContext _db = new HospitalDbContext();

        public void Update(int estimateId, int workerId, int? nurseId,int? refererId)
        {
            var update = _db.VariousDocumentEstimates.First(v => v.Id == estimateId);
            update.WorkerId = workerId;
            update.NurseId = nurseId;
            update.ReferrerId = refererId;
            update.Date=DateTime.Today;
            update.Edit = true;

            _db.VariousDocumentEstimates.AddOrUpdate(update);
            _db.SaveChanges();
        }

        public object Show(int patientId)
        {
            var getEstimate = from v in _db.VariousDocumentEstimates where v.PatientId==patientId
                select new
                {
                    v.Id,
                    v.Date,
                    Doctor = v.Worker.LastName ,
                    Nurse = v.Worker1.LastName ,
                    Referrer = v.Referrer.LastName ,
                    Category = v.VariousDocumentCategory.Name,
                    v.Edit
                };
            var bs = new BindingSource { DataSource = getEstimate.ToList() };

            return bs;
        }
    }
}
