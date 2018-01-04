using System;
using System.Windows.Forms;
using System.Data.Entity.Migrations;
using Hospital_Entity_Framework;
using System.Linq;
using PatientManagement.Interface;

namespace PatientManagement.Class
{
    public class MedicalImagingEstimate : IEstimate 
    {
        private readonly HospitalDbContext _db = new HospitalDbContext();
        private readonly BindingSource _bs = new BindingSource();

        public void Insert(int visitid, int visitcount, int patientid, int categoryid, int workerid, int? nurseid, int? referrerid, DateTime date, string description)
        {
            var insert = new Hospital_Entity_Framework.MedicalImagingEstimate() 
            {
                PatientId=patientid,
                CategoryId = categoryid,
                WorkerId = workerid,
                NurseId = nurseid,ReferrerId = referrerid,
                Date = date,
                Description =description,
                Edit = false
            };
            _db.MedicalImagingEstimates.Add(insert);
            _db.SaveChanges();
            InsertIntoVisit(visitid, visitcount, patientid, description);
        }

        private void InsertIntoVisit(int visitid, int visitcount, int patientid, string description)
        {
            var get = _db.MedicalImagingEstimates.Where(v => v.PatientId == patientid)
                .First(v => v.Description == description);

            _db.Visits.First(v => v.Id == visitid && v.VisitCount == visitcount).MedicalImagingEstimates.Add(get);
            _db.SaveChanges();
        }

        public void Update(int id, int categoryid, int workerid, int? nurseid, int? referrerid, DateTime date, string description)
        {
            var update = _db.MedicalImagingEstimates.Single(v => v.Id == id);
            update.CategoryId  = categoryid ;
            update.WorkerId = workerid;
            update.NurseId = nurseid;
            update.ReferrerId = referrerid;
            update.Date = date;
            update.Description = description;
            update.Edit = true;
            _db.MedicalImagingEstimates.AddOrUpdate(update);
            _db.SaveChanges();
        }

        public object Show()
        {
            var getestimate = from v in _db.MedicalImagingEstimates 
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
