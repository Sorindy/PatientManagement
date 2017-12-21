using System;
using System.Linq;
using System.Windows.Forms;
using Hospital_Entity_Framework;
using PatientManagement.Interface;

namespace PatientManagement.Class
{
    class LaboratoryHistory:IHistory
    {
        private readonly HospitalDbContext _db = new HospitalDbContext();

        public void Insert(int estimateId, int workerId, string description)
        {
            var insert = new LaboratoryEstimateEditHistory() { EstimateId = estimateId, WorkerId = workerId, Description = description, Date = DateTime.Today };
            _db.LaboratoryEstimateEditHistories.Add(insert);
            _db.SaveChanges();
        }

        public object Show()
        {
            var getEstimate = from v in _db.LaboratoryEstimates
                select new
                {
                    v.Id,
                    v.Date,
                    WorkerName = v.Worker.Name,
                    v.LaboratoryCategory.Name
                };
            var bs = new BindingSource { DataSource = getEstimate.ToList() };

            return bs;
        }

        public object ShowHistory(int estmateId)
        {
            var bs = new BindingSource();

            var getHistory = from b in _db.LaboratoryEstimateEditHistories
                where b.EstimateId == estmateId
                select new { b.Id, b.Date, b.Worker.Name };
            bs.DataSource = getHistory.ToList();

            return bs;
        }
    }
}
