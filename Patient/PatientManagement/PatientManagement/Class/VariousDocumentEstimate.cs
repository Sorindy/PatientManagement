using System;
using Hospital_Entity_Framework;
using System.Data.Entity.Migrations;
using System.Windows.Forms;
using System.Linq;
using PatientManagement.Interface;

namespace PatientManagement.Class
{
   public class VariousDocumentEstimate: IEstimate 
    {
        private readonly HospitalDbContext _db = new HospitalDbContext();
        private readonly BindingSource _bs = new BindingSource();

        public void Insert(int visitid, int visitcount, int patientid, int categoryid, int workerid, int? nurseid, int? referrerid, DateTime date, string description)
        {
            var insert = new Hospital_Entity_Framework.VariousDocumentEstimate() 
            {
                PatientId=patientid,
                CategoryId = categoryid,
                WorkerId = workerid,
                NurseId = nurseid,ReferrerId = referrerid,
                Date = date,
                Description = description,
                Edit = false
            };
            _db.VariousDocumentEstimates.Add(insert);
            _db.SaveChanges();
            InsertIntoVisit(visitid, visitcount, patientid, description);
        }

        private void InsertIntoVisit(int visitid, int visitcount, int patientid, string description)
        {
            var get = _db.VariousDocumentEstimates.Where(v => v.PatientId == patientid)
                .First(v => v.Description == description);

            _db.Visits.First(v => v.Id == visitid && v.VisitCount == visitcount).VariousDocumentEstimates.Add(get);
            _db.SaveChanges();
        }

        public void Update(int id, int categoryid, int workerid, int? nurseid, int? referrerid, DateTime date, string description)
        {
            var update = _db.VariousDocumentEstimates.Single(v => v.Id == id);
            update.CategoryId  = categoryid ;
            update.WorkerId = workerid;
            update.NurseId = nurseid;
            update.ReferrerId = referrerid;
            update.Date = date;
            update.Description = description;
            update.Edit = true;
            _db.VariousDocumentEstimates.AddOrUpdate(update);
            _db.SaveChanges();
        }

        public object Show()
        {
            var getestimate = from v in _db.VariousDocumentEstimates 
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
