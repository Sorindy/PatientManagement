using System;
using System.Windows.Forms;
using Hospital_Entity_Framework;
using System.Data.Entity.Migrations;
using System.Linq;
using PatientManagement.Interface;

/*using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;*/

namespace PatientManagement.Class
{
   public class LaboratoryEstimate : IEstimate 
    {
        private HospitalDbContext _db = new HospitalDbContext();
        private BindingSource _bs = new BindingSource();

        public void Insert(int categoryid,int workerid,DateTime date,string description)
        {
            var insert = new Hospital_Entity_Framework.LaboratoryEstimate()
            {
                CategoryId = categoryid,
                WorkerId = workerid,
                Date = date,
                Description =description,
            };
            _db.LaboratoryEstimates.Add(insert);
            _db.SaveChanges();
        }

        public void Update(int id, int categoryid, int workerid, DateTime date, string description)
        {
            var update = _db.LaboratoryEstimates.Single(v => v.Id == id);
            update.CategoryId  = categoryid ;
            update.WorkerId = workerid;
            update.Date = date;
            update.Description = description;
            _db.LaboratoryEstimates.AddOrUpdate(update);
            _db.SaveChanges();
        }

        public void Delete(int id)
        {
            var delete = _db.LaboratoryEstimates.Single(vid => vid.Id == id);
            _db.LaboratoryEstimates.Remove(delete);
            _db.SaveChanges();
        }

        public object Show()
        {
            var getestimate = from v in _db.LaboratoryEstimates 
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
