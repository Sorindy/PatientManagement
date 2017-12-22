using System;
using System.Collections.Generic;
using System.Diagnostics.PerformanceData;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hospital_Entity_Framework;

namespace PatientManagement.Class
{
    class Refferrer
    {
        private readonly HospitalDbContext _db = new HospitalDbContext();

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

        public void Update(int id)
        {

        }

        public void Delete(int id)
        {

        }

        public object Show()
        {
            return 0;
        }

    }
}
