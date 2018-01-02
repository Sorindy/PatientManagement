using System;
using System.Windows.Forms;
using System.Data.Entity.Migrations;
using Hospital_Entity_Framework;
using System.Linq;
using PatientManagement.Interface;

/*using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;*/

namespace PatientManagement.Class
{
    public class PrescriptionEstimate : IEstimate 
    {
        private readonly HospitalDbContext _db = new HospitalDbContext();
        private readonly BindingSource _bs = new BindingSource();

        public void Insert(int visitid, int visitcount, int patientid, int categoryid, int workerid, int? nurseid, int? referrerid, DateTime date, string description)
        {
            var insert = new Hospital_Entity_Framework.PrescriptionEstimate() 
            {
                PatientId=patientid,
                CategoryId = categoryid,
                WorkerId = workerid,
                NurseId = nurseid,
                ReferrerId = referrerid,
                Date = date,
                Description =description,
                Edit = false
            };
            _db.PrescriptionEstimates.Add(insert);
            _db.SaveChanges();
            InsertIntoVisit(visitid, visitcount, patientid, description);
        }

        private void InsertIntoVisit(int visitid, int visitcount, int patientid, string description)
        {
            var get = _db.PrescriptionEstimates.Where(v => v.PatientId == patientid)
                .First(v => v.Description == description);

            _db.Visits.First(v => v.Id == visitid && v.VisitCount == visitcount).PrescriptionEstimates.Add(get);
            _db.SaveChanges();
        }

        public void Update(int id, int categoryid, int workerid, int? nurseid, int? referrerid, DateTime date, string description)
        {
            var update = _db.PrescriptionEstimates.Single(v => v.Id == id);
            update.CategoryId  = categoryid ;
            update.WorkerId = workerid;
            update.NurseId = nurseid;
            update.ReferrerId = referrerid;
            update.Date = date;
            update.Description = description;
            _db.PrescriptionEstimates.AddOrUpdate(update);
            _db.SaveChanges();
        }

        public void Delete(int id)
        {
            var delete = _db.PrescriptionEstimates.Single(vid => vid.Id == id);
            _db.PrescriptionEstimates.Remove(delete);
            _db.SaveChanges();
        }

        public object Show()
        {
            var getestimate = from v in _db.PrescriptionEstimates 
                select new
                {
                    v.Id,
                    v.CategoryId,
                    v.WorkerId,
                    v.Date,
                    v.Description,
                };
            _bs.DataSource = getestimate.ToList();
            return _bs;
        }
    }
}
