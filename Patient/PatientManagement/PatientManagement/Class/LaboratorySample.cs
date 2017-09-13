using System;
using System.Windows.Forms;
using System.Data.Entity.Migrations;
using Hospital_Entity_Framework;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientManagement
{
   public class LaboratorySample : ISample 
    {
        private HospitalDbContext _db = new HospitalDbContext();
        private Hospital_Entity_Framework.LaboratorySample _laboratorySample  = new Hospital_Entity_Framework.LaboratorySample();
        private BindingSource _bs = new BindingSource();

        public LaboratorySample()
        {
        }

        public string AutoId()
        {
            try
            {
                var getLastId = _db.LaboratorySamples.OrderByDescending(v => v.Id).First();
                var getvalue = getLastId.Id;
                var num = Convert.ToInt32(getvalue.Substring(16));
                num += 1;
                _laboratorySample.Id = string.Concat("LaboratorySample", num);
            }
            catch
            {
                _laboratorySample.Id = "LaboratorySample1";
            }
            return _laboratorySample.Id;
        }

        public void Insert(string id, string title, string description)
        {
            var insert = new Hospital_Entity_Framework.LaboratorySample()
            {
                Id = id,
                Title=title,
                Description=description,
            };
            _db.LaboratorySamples.Add(insert);
            _db.SaveChanges();
        }

        public void Update(string id, string title, string description)
        {
            var update = _db.LaboratorySamples.Single(v => v.Id == id);
            update.Title = title;
            update.Description = description;
            _db.LaboratorySamples.AddOrUpdate(update);
            _db.SaveChanges();
        }

        public void Delete(string id)
        {
            var delete = _db.LaboratorySamples.Single(vid => vid.Id == id);
            _db.LaboratorySamples.Remove(delete);
            _db.SaveChanges();
        }

        public object Show()
        {
            var getsample = from v in _db.LaboratorySamples 
                select new
                {
                    v.Id,
                    v.Title,
                    v.Description,
                };
            _bs.DataSource = getsample.ToList();
            return _bs;
        }
    }
}
