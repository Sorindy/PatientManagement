using System;
using Hospital_Entity_Framework;
using System.Data.Entity.Migrations;
using System.Windows.Forms;
using System.Linq;
/*using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;*/

namespace PatientManagement.Class
{
   public class VariousDocumentEstimate: IEstimate 
    {
        private HospitalDbContext _db = new HospitalDbContext();
        private VariousDocumentEstimante _variousDocumentEstimante   =new VariousDocumentEstimante();
        private BindingSource _bs = new BindingSource();

        public string AutoId()
        {
            try
            {
                var getLastId = _db.VariousDocumentEstimantes.OrderByDescending(v => v.Id).First();
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
            var insert = new VariousDocumentEstimante() 
            {
                Id = id,
                CategoryId = categoryid,
                WorkerId = workerid,
                Date = date,
                Description =description,
            };
            _db.VariousDocumentEstimantes.Add(insert);
            _db.SaveChanges();
        }

        public void Update(string id, string categoryid, string workerid, DateTime date, string description)
        {
            var update = _db.VariousDocumentEstimantes.Single(v => v.Id == id);
            update.CategoryId  = categoryid ;
            update.WorkerId = workerid;
            update.Date = date;
            update.Description = description;
            _db.VariousDocumentEstimantes.AddOrUpdate(update);
            _db.SaveChanges();
        }

        public void Delete(string id)
        {
            var delete = _db.VariousDocumentEstimantes.Single(vid => vid.Id == id);
            _db.VariousDocumentEstimantes.Remove(delete);
            _db.SaveChanges();
        }

        public object Show()
        {
            var getestimate = from v in _db.VariousDocumentEstimantes 
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
