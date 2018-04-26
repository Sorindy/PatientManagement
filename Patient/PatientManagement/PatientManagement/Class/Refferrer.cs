using System.Data.Entity.Migrations;
using System.Linq;
using System.Windows.Forms;
using Hospital_Entity_Framework;

namespace PatientManagement.Class
{
    class Refferrer
    {
        private readonly HospitalDbContext _db = new HospitalDbContext();
        private readonly BindingSource _bs = new BindingSource();

        public Referrer Insert(string fname,string lname,string specially,string workplace,string phone1 , string phone2 ,string email)
        {
            var insert = new Referrer()
            {
                LastName = lname,
                FirstName = fname,
                Specialty=specially ,
                WorkPlace=workplace,
                Phone1=phone1,
                Phone2=phone2,
                Email=email 
            };
            _db.Referrers.Add(insert);
            _db.SaveChanges();
            return insert;
        }

        public Referrer Update(int id, string fname,string lname, string specially, string workplace, string phone1, string phone2, string email)
        {
            var update = _db.Referrers.Single(v => v.Id == id);
            update.FirstName = fname;
            update.LastName = lname;
            update.Specialty = specially;
            update.WorkPlace = workplace;
            update.Phone1 = phone1;
            update.Phone2 = phone2;
            update.Email = email;
            _db.Referrers.AddOrUpdate(update);
            _db.SaveChanges();
            return update;
        }

        public object Show()
        {
            var select = from v in _db.Referrers
                select new
                {
                    v.Id,v.LastName,v.Specialty,v.WorkPlace,v.Phone1,v.Phone2,v.Email 
                };
            _bs.DataSource = select.ToList();
            return _bs;
        }

        public Referrer GetRefferrer(int id)
        {
            var get = _db.Referrers.First(v => v.Id == id);
            return get;
        }
    }
}
