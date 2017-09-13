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
    public class ConsultationEstimate : IEstimate 
    {
        private HospitalDbContext _db = new HospitalDbContext();
        private Hospital_Entity_Framework.ConsultationEstimate  _consultationEstimate  =new Hospital_Entity_Framework.ConsultationEstimate();
        private BindingSource _bs = new BindingSource();

        public string AutoId()
        {
            try
            {
                var getLastId = _db.ConsultationEstimates.OrderByDescending(v => v.Id).First();
                var getvalue = getLastId.Id;
                var num = Convert.ToInt32(getvalue.Substring(20));
                num += 1;
                _consultationEstimate.Id = string.Concat("ConsultationEstimate", num);
            }
            catch
            {
                _consultationEstimate.Id = "ConsultationEstimate1";
            }
            return _consultationEstimate.Id;
        }

        public void Insert(string id, string categoryid,string workerid,DateTime date,string description)
        {
            var insert = new Hospital_Entity_Framework.ConsultationEstimate()
            {
                Id = id,
                CategoryId = categoryid,
                WorkerId = workerid,
                Date = date,
                Description =description,
            };
            _db.ConsultationEstimates.Add(insert);
            _db.SaveChanges();
        }

        public void Update(string id, string categoryid, string workerid, DateTime date, string description)
        {
            var update = _db.ConsultationEstimates.Single(v => v.Id == id);
            update.CategoryId  = categoryid ;
            update.WorkerId = workerid;
            update.Date = date;
            update.Description = description;
            _db.ConsultationEstimates.AddOrUpdate(update);
            _db.SaveChanges();
        }

        public void Delete(string id)
        {
            var delete = _db.ConsultationEstimates.Single(vid => vid.Id == id);
            _db.ConsultationEstimates.Remove(delete);
            _db.SaveChanges();
        }

        public object Show()
        {
            var getestimate = from v in _db.ConsultationEstimates 
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
