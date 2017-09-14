using System;
using System.Windows.Forms;
using Hospital_Entity_Framework;
using System.Data.Entity.Migrations;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientManagement
{
   public class ConsultationSample: ISample
   {
        private HospitalDbContext _db = new HospitalDbContext();
        private Hospital_Entity_Framework.ConsultationSample _consultationSample = new Hospital_Entity_Framework.ConsultationSample();
        private BindingSource _bs = new BindingSource();

        public ConsultationSample()
        {
        }

        public string AutoId()
        {
            try
            {
                var getLastId = _db.ConsultationSamples.OrderByDescending(v => v.Id).First();
                var getvalue = getLastId.Id;
                var num = Convert.ToInt32(getvalue.Substring(18));
                num += 1;
                _consultationSample.Id = string.Concat("ConsultationSample", num);
            }
            catch 
            {
                _consultationSample.Id = "ConsultationSample1";
            }
            return _consultationSample.Id;
        }

        public void Insert(string id, string title, string description)
        {
            var insert = new Hospital_Entity_Framework.ConsultationSample()
            {
                Id = id,
                Title=title,
                Description=description,
            };
            _db.ConsultationSamples.Add(insert);
            _db.SaveChanges();
        }

        public void Update(string id, string title, string description)
        {
            var update = _db.ConsultationSamples.Single(v => v.Id == id);
            update.Title = title;
            update.Description = description;
            _db.ConsultationSamples.AddOrUpdate(update);
            _db.SaveChanges();
        }

        public void Delete(string id)
        {
            var delete = _db.ConsultationSamples.Single(vid => vid.Id == id);
            _db.ConsultationSamples.Remove(delete);
            _db.SaveChanges();
        }

       public object Show()
       {
           var getsample = from v in _db.ConsultationSamples
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
