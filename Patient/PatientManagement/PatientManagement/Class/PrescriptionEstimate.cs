using System;
using System.Windows.Forms;
using System.Data.Entity.Migrations;
using Hospital_Entity_Framework;
using System.Linq;
using PatientManagement.Interface;

/*using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;*/

namespace PatientManagement.Class
{
    public class PrescriptionEstimate : IEstimate 
    {
        private HospitalDbContext _db = new HospitalDbContext();
        private Hospital_Entity_Framework.PrescriptionEstimate   _prescriptionEstimate   =new Hospital_Entity_Framework.PrescriptionEstimate();
        private BindingSource _bs = new BindingSource();

        public string AutoId()
        {
            try
            {
                var getLastId = _db.PrescriptionEstimates.OrderByDescending(v => v.Id).First();
                var getvalue = getLastId.Id;
                var num = Convert.ToInt32(getvalue.Substring(20));
                num += 1;
                _prescriptionEstimate.Id = string.Concat("PrescriptionEstimate", num);
            }
            catch
            {
                _prescriptionEstimate.Id = "PrescriptionEstimate1";
            }
            return _prescriptionEstimate.Id;
        }

        public void Insert(string id, string categoryid,string workerid,DateTime date,string description)
        {
            var insert = new Hospital_Entity_Framework.PrescriptionEstimate() 
            {
                Id = id,
                CategoryId = categoryid,
                WorkerId = workerid,
                Date = date,
                Description =description,
            };
            _db.PrescriptionEstimates.Add(insert);
            _db.SaveChanges();
        }

        public void Update(string id, string categoryid, string workerid, DateTime date, string description)
        {
            var update = _db.PrescriptionEstimates.Single(v => v.Id == id);
            update.CategoryId  = categoryid ;
            update.WorkerId = workerid;
            update.Date = date;
            update.Description = description;
            _db.PrescriptionEstimates.AddOrUpdate(update);
            _db.SaveChanges();
        }

        public void Delete(string id)
        {
            var delete = _db.PrescriptionEstimates.Single(vid => vid.Id == id);
            _db.PrescriptionEstimates.Remove(delete);
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
