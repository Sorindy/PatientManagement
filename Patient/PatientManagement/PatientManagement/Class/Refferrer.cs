using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Diagnostics.PerformanceData;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hospital_Entity_Framework;

namespace PatientManagement.Class
{
    class Refferrer
    {
        private readonly HospitalDbContext _db = new HospitalDbContext();
        private BindingSource _bs = new BindingSource();

        public void Insert(string name,string specially,string workplace,string phone1 , string phone2 ,string email)
        {
            var insert = new Referrer()
            {
                Name = name,
                Specialty=specially ,
                WorkPlace=workplace,
                Phone1=phone1,
                Phone2=phone2,
                Email=email 
            };
            _db.Referrers.Add(insert);
            _db.SaveChanges();
        }

        public void Update(int id, string name, string specially, string workplace, string phone1, string phone2, string email)
        {
            var update = _db.Referrers.Single(v => v.Id == id);
            update.Name = name;
            update.Specialty = specially;
            update.WorkPlace = workplace;
            update.Phone1 = phone1;
            update.Phone2 = phone2;
            update.Email = email;
            _db.Referrers.AddOrUpdate(update);
            _db.SaveChanges();

        }

        public object Show()
        {
            var select = from v in _db.Referrers
                select new
                {
                    v.Id,v.Name,v.Specialty,v.WorkPlace,v.Phone1,v.Phone2,v.Email 
                };
            _bs.DataSource = select.ToList();
            return _bs;
        }

    }
}
