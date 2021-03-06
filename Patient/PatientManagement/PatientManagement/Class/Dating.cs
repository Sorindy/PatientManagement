﻿using System;
using System.Windows.Forms;
using System.Data.Entity.Migrations;
using Hospital_Entity_Framework;
using System.Linq;

namespace PatientManagement.Class
{
   public class Dating
    {
        private readonly HospitalDbContext _db = new HospitalDbContext();
        private readonly  BindingSource _bs = new BindingSource();

        public void Insert(int patientid,int workerid, DateTime date)
        {
            var insert = new Hospital_Entity_Framework.Dating() 
            {
                PatientId = patientid,
                WorkerId = workerid,
                Date = date ,
            };
            _db.Datings.Add(insert);
            _db.SaveChanges();
        }

        public void Update(int id, DateTime date)
        {
            var update = _db.Datings.Single(v => v.Id == id);
            update.Date = date;
            _db.Datings.AddOrUpdate(update);
            _db.SaveChanges();
        }

        public void Delete(int id)
        {
            var delete = _db.Datings.Single(vid => vid.Id == id);
            _db.Datings.Remove(delete);
            _db.SaveChanges();
        }

        public object Show(int workerid)
        {
            var getcategory = from v in _db.Datings 
                where v.WorkerId==workerid 
                select new
                {
                    v.Id,
                    v.Date,
                    v.PatientId,
                    v.Patient.FirstName,
                    v.Patient.LastName ,
                    v.Patient.KhmerName,
                    v.Patient.PatientIdentify
                };
            _bs.DataSource = getcategory.ToList();
            return _bs;
        }



    }
}
