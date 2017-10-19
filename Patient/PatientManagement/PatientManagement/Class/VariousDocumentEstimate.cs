using System;
using Hospital_Entity_Framework;
using System.Data.Entity.Migrations;
using System.Windows.Forms;
using System.Linq;
using PatientManagement.Interface;

/*using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;*/

namespace PatientManagement.Class
{
   public class VariousDocumentEstimate: IEstimate 
    {
        private HospitalDbContext _db = new HospitalDbContext();
        private BindingSource _bs = new BindingSource();

        public void Insert(int categoryid,int workerid,DateTime date,string description)
        {
            var insert = new Hospital_Entity_Framework.VariousDocumentEstimate() 
            {
                CategoryId = categoryid,
                WorkerId = workerid,
                Date = date,
                Description =description,
            };
            _db.VariousDocumentEstimates.Add(insert);
            _db.SaveChanges();
        }

        public void Update(int id, int categoryid, int workerid, DateTime date, string description)
        {
            var update = _db.VariousDocumentEstimates.Single(v => v.Id == id);
            update.CategoryId  = categoryid ;
            update.WorkerId = workerid;
            update.Date = date;
            update.Description = description;
            _db.VariousDocumentEstimates.AddOrUpdate(update);
            _db.SaveChanges();
        }

        public void Delete(int id)
        {
            var delete = _db.VariousDocumentEstimates.Single(vid => vid.Id == id);
            _db.VariousDocumentEstimates.Remove(delete);
            _db.SaveChanges();
        }

        public object Show()
        {
            var getestimate = from v in _db.VariousDocumentEstimates 
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
