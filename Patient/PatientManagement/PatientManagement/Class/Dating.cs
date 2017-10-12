using System;
using System.Windows.Forms;
using System.Data.Entity.Migrations;
using Hospital_Entity_Framework;
using System.Linq;
/*using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;*/

namespace PatientManagement.Class
{
   public class Dating
    {
        private HospitalDbContext _db = new HospitalDbContext();
        private Hospital_Entity_Framework.Dating _dating = new Hospital_Entity_Framework.Dating();
        private BindingSource _bs = new BindingSource();

        public string AutoId()
        {
            try
            {
                var getLastId = _db.Datings.OrderByDescending(v => v.Id).First();
                var getvalue = getLastId.Id;
                var num = Convert.ToInt32(getvalue.Substring(6));
                num += 1;
                _dating.Id = string.Concat("Dating", num);
            }
            catch
            {
                _dating.Id = "Dating1";
            }
            return _dating.Id;
        }

        public void Insert(string id, string patientid,string workerid, DateTime date)
        {
            var insert = new Hospital_Entity_Framework.Dating() 
            {
                Id = id,
                PatientId = patientid,
                WorkerId = workerid,
                Date = date ,
            };
            _db.Datings.Add(insert);
            _db.SaveChanges();
        }

        public void Update(string id, DateTime date)
        {
            var update = _db.Datings.Single(v => v.Id == id);
            update.Date = date;
            _db.Datings.AddOrUpdate(update);
            _db.SaveChanges();
        }

        public void Delete(string id)
        {
            var delete = _db.Datings.Single(vid => vid.Id == id);
            _db.Datings.Remove(delete);
            _db.SaveChanges();
        }

        public object Show()
        {
            var getcategory = from v in _db.Datings 
                select new
                {
                    v.Id,
                    v.PatientId,
                    v.WorkerId,
                    v.Date ,
                };
            _bs.DataSource = getcategory.ToList();
            return _bs;
        }



    }
}
