using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hospital_Entity_Framework;

namespace PatientManagement.Class
{
    class ServiceCategory
    {
        HospitalDbContext _db=new HospitalDbContext();

        public void Insert(string serviceId, string categoryId)
        {
            var insert=new Hospital_Entity_Framework.ServiceCategory(){ServiceId = serviceId,CategoryId = categoryId};
            _db.ServiceCategories.Add(insert);
        }

        public void Delete(string serviceId)
        {
            var delete = _db.ServiceCategories.Single(v => v.ServiceId == serviceId);

            _db.ServiceCategories.Remove(delete);
            _db.SaveChanges();
        }
    }
}
