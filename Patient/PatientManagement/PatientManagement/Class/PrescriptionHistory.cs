using System;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Windows.Forms;
using Hospital_Entity_Framework;
using PatientManagement.Interface;

namespace PatientManagement.Class
{
    class PrescriptionHistory:IHistory
    {
        private readonly HospitalDbContext _db = new HospitalDbContext();

        public void Update(int estimateId, int workerId, int? nurseId, int? refererId)
        {
            var update = _db.PrescriptionEstimates.First(v => v.Id == estimateId);
            update.WorkerId = workerId;
            update.NurseId = nurseId;
            update.ReferrerId = refererId;
            update.Date = DateTime.Today;
            update.Edit = true;

            _db.PrescriptionEstimates.AddOrUpdate(update);
            _db.SaveChanges();
        }

        public object Show(int patientId)
        {
            var getEstimate = from v in _db.PrescriptionEstimates where v.PatientId==patientId
                select new
                {
                    v.Id,
                    v.Date,
                    Doctor = v.Worker.Name,
                    Nurse = v.Worker1.Name,
                    Referrer = v.Referrer.Name,
                    Category = v.PrescriptionCategory.Name,
                    v.Edit
                };
            var bs = new BindingSource { DataSource = getEstimate.ToList() };

            return bs;
        }

        public object ShowHistory(int estmateId)
        {
            var bs = new BindingSource();

            var getHistory = from b in _db.PrescriptionEstimateEditHistories
                where b.EstimateId == estmateId
                select new { b.Id, b.Date, b.Worker.Name };
            bs.DataSource = getHistory.ToList();

            return bs;
        }
    }
}
