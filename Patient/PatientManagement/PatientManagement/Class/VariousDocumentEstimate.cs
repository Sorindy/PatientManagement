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
        private Hospital_Entity_Framework.VariousDocumentEstimate _variousDocumentEstimante   =new Hospital_Entity_Framework.VariousDocumentEstimate();
        private BindingSource _bs = new BindingSource();

        public string AutoId()
        {
            try
            {
                var getLastId = _db.VariousDocumentEstimates.OrderByDescending(v => v.Id).First();
                var getvalue = getLastId.Id;
                var num = Convert.ToInt32(getvalue.Substring(23));
                num += 1;
                _variousDocumentEstimante.Id = string.Concat("VariousDocumentEstimate", num);
            }
            catch
            {
                _variousDocumentEstimante.Id = "VariousDocumentEstimate1";
            }
            return _variousDocumentEstimante.Id;
        }

        public void Insert(string id, string categoryid,string workerid,DateTime date,string description)
        {
            var insert = new Hospital_Entity_Framework.VariousDocumentEstimate() 
            {
                Id = id,
                CategoryId = categoryid,
                WorkerId = workerid,
                Date = date,
                Description =description,
            };
            _db.VariousDocumentEstimates.Add(insert);
            _db.SaveChanges();
        }

        public void Update(string id, string categoryid, string workerid, DateTime date, string description)
        {
            var update = _db.VariousDocumentEstimates.Single(v => v.Id == id);
            update.CategoryId  = categoryid ;
            update.WorkerId = workerid;
            update.Date = date;
            update.Description = description;
            _db.VariousDocumentEstimates.AddOrUpdate(update);
            _db.SaveChanges();
        }

        public void Delete(string id)
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
