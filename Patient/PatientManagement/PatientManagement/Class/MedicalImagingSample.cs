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
   public class MedicalImagingSample : ISample 
    {
        private HospitalDbContext _db = new HospitalDbContext();
        private Hospital_Entity_Framework.MedicalImagingSample _medicalImagingSample  = new Hospital_Entity_Framework.MedicalImagingSample();
        private BindingSource _bs = new BindingSource();

        public MedicalImagingSample ()
        {
        }

        public string AutoId()
        {
            try
            {
                var getLastId = _db.MedicalImagingSamples.OrderByDescending(v => v.Id).First();
                var getvalue = getLastId.Id;
                var num = Convert.ToInt32(getvalue.Substring(20));
                num += 1;
                _medicalImagingSample.Id = string.Concat("MedicalImagingSample", num);
            }
            catch
            {
                _medicalImagingSample.Id = "MedicalImagingSample1";
            }
            return _medicalImagingSample.Id;
        }

        public void Insert(string id, string title, string description)
        {
            var insert = new Hospital_Entity_Framework.MedicalImagingSample() 
            {
                Id = id,
                Title=title,
                Description=description,
            };
            _db.MedicalImagingSamples.Add(insert);
            _db.SaveChanges();
        }

        public void Update(string id, string title, string description)
        {
            var update = _db.MedicalImagingSamples.Single(v => v.Id == id);
            update.Title = title;
            update.Description = description;
            _db.MedicalImagingSamples.AddOrUpdate(update);
            _db.SaveChanges();
        }

        public void Delete(string id)
        {
            var delete = _db.MedicalImagingSamples.Single(vid => vid.Id == id);
            _db.MedicalImagingSamples.Remove(delete);
            _db.SaveChanges();
        }

        public object Show()
        {
            var getsample = from v in _db.MedicalImagingSamples 
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
