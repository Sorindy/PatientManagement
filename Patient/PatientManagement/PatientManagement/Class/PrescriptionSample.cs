using System;
using System.Windows.Forms;
using System.Data.Entity.Migrations;
using Hospital_Entity_Framework;
using System.Linq;
/*using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;*/

namespace PatientManagement
{
   public class PrescriptionSample : ISample
   {
       
        private HospitalDbContext _db = new HospitalDbContext();
        private Hospital_Entity_Framework.PrescriptionSample  _prescriptionSample = new Hospital_Entity_Framework.PrescriptionSample();
        private BindingSource _bs = new BindingSource();

        public string AutoId()
        {
            try
            {
                var getLastId = _db.PrescriptionSamples.OrderByDescending(v => v.Id).First();
                var getvalue = getLastId.Id;
                var num = Convert.ToInt32(getvalue.Substring(18));
                num += 1;
                _prescriptionSample.Id = string.Concat("PrescriptionSample", num);
            }
            catch
            {
                _prescriptionSample.Id = "PrescriptionSample1";
            }
            return _prescriptionSample.Id;
        }

        public void Insert(string id, string title, string description)
        {
            var insert = new Hospital_Entity_Framework.PrescriptionSample() 
            {
                Id = id,
                Title=title,
                Description=description,
            };
            _db.PrescriptionSamples.Add(insert);
            _db.SaveChanges();
        }

        public void Update(string id, string title, string description)
        {
            var update = _db.PrescriptionSamples.Single(v => v.Id == id);
            update.Title = title;
            update.Description = description;
            _db.PrescriptionSamples.AddOrUpdate(update);
            _db.SaveChanges();
        }

        public void Delete(string id)
        {
            var delete = _db.PrescriptionSamples.Single(vid => vid.Id == id);
            _db.PrescriptionSamples.Remove(delete);
            _db.SaveChanges();
        }

        public object Show()
        {
            var getsample = from v in _db.PrescriptionSamples 
                select new
                {
                    v.Id,
                    v.Title,
                    v.Description,
                };
            _bs.DataSource = getsample.ToList();
            return _bs;
        }

       public object Show_Sample_Title()
       {
           var getsample = _db.PrescriptionSamples.Select(v => v.Title);
           return getsample.ToList();
       }

       public string Search_Title(string title)
       {
           var getsample = _db.PrescriptionSamples.Single(v => v.Title == title);
           return getsample.Description;
       }

    }
}
