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
    public class MedicalImagingEstimate : IEstimate 
    {
        private HospitalDbContext _db = new HospitalDbContext();
        private Hospital_Entity_Framework.MedicalImagingEstimate  _medicalImagingEstimate  =new Hospital_Entity_Framework.MedicalImagingEstimate();
        private BindingSource _bs = new BindingSource();

        public string AutoId()
        {
            try
            {
                var getLastId = _db.MedicalImagingEstimates.OrderByDescending(v => v.Id).First();
                var getvalue = getLastId.Id;
                var num = Convert.ToInt32(getvalue.Substring(22));
                num += 1;
                _medicalImagingEstimate.Id = string.Concat("MedicalImagingEstimate", num);
            }
            catch
            {
                _medicalImagingEstimate.Id = "MedicalImagingEstimate1";
            }
            return _medicalImagingEstimate.Id;
        }

        public void Insert(string id, string categoryid,string workerid,DateTime date,string description)
        {
            var insert = new Hospital_Entity_Framework.MedicalImagingEstimate() 
            {
                Id = id,
                CategoryId = categoryid,
                WorkerId = workerid,
                Date = date,
                Description =description,
            };
            _db.MedicalImagingEstimates.Add(insert);
            _db.SaveChanges();
        }

        public void Update(string id, string categoryid, string workerid, DateTime date, string description)
        {
            var update = _db.MedicalImagingEstimates.Single(v => v.Id == id);
            update.CategoryId  = categoryid ;
            update.WorkerId = workerid;
            update.Date = date;
            update.Description = description;
            _db.MedicalImagingEstimates.AddOrUpdate(update);
            _db.SaveChanges();
        }

        public void Delete(string id)
        {
            var delete = _db.MedicalImagingEstimates.Single(vid => vid.Id == id);
            _db.MedicalImagingEstimates.Remove(delete);
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
