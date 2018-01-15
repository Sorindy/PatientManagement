﻿using System;
using System.Windows.Forms;
using System.Data.Entity.Migrations;
using Hospital_Entity_Framework;
using System.Linq;
using PatientManagement.Interface;

namespace PatientManagement.Class
{
    public class PrescriptionEstimate : IEstimate 
    {
        private readonly HospitalDbContext _db = new HospitalDbContext();
        private readonly BindingSource _bs = new BindingSource();

        public void Insert(int? visitid, int? visitcount, int patientid, int categoryid, int workerid, int? nurseid, int? referrerid, DateTime date, string description)
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

            if (visitid==null&&visitcount==null||visitid==0&&visitcount==0)
            {
                CreateVisit(patientid,description);
            }
            else
            {
                InsertIntoVisit(visitid, visitcount, patientid, description);
            }

        }

        private void CreateVisit(int patientId,string description)
        {
            try
            {
                var checkVisit = _db.Visits.Where(v => v.PatientId == patientId).OrderByDescending(v => v.VisitCount).Select(v => v.VisitCount).First();

                var insert = new Hospital_Entity_Framework.Visit { VisitCount = checkVisit + 1, PatientId = patientId, Date = DateTime.Now };
                _db.Visits.Add(insert);
                _db.SaveChanges();

                var getVisit = _db.Visits.Single(v => v.PatientId == patientId && v.VisitCount == checkVisit + 1);

                var get = _db.PrescriptionEstimates.Where(v => v.PatientId == patientId)
                    .First(v => v.Description == description);

                _db.Visits.First(v => v.Id == getVisit.Id && v.VisitCount == getVisit.VisitCount).PrescriptionEstimates.Add(get);
                _db.SaveChanges();
            }
            catch
            {
                var insert = new Hospital_Entity_Framework.Visit { VisitCount = 1, PatientId = patientId, Date = DateTime.Now };
                _db.Visits.Add(insert);
                _db.SaveChanges();

                var getVisit = _db.Visits.Single(v => v.PatientId == patientId && v.VisitCount == 1);
                var get = _db.PrescriptionEstimates.Where(v => v.PatientId == patientId)
                    .First(v => v.Description == description);

                _db.Visits.First(v => v.Id == getVisit.Id && v.VisitCount == getVisit.VisitCount).PrescriptionEstimates.Add(get);
                _db.SaveChanges();
            }
        }

        private void InsertIntoVisit(int? visitid, int? visitcount, int patientid, string description)
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
            update.Edit = true;
            _db.PrescriptionEstimates.AddOrUpdate(update);
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
