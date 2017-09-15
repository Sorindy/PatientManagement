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
   public class MedicalHistory
    {
        private HospitalDbContext _db = new HospitalDbContext();
        private Hospital_Entity_Framework.MedicalHistory  _medicalHistory   =new Hospital_Entity_Framework.MedicalHistory();
        private BindingSource _bs = new BindingSource();

        public string AutoId()
        {
            try
            {
                var getLastId = _db.MedicalHistories.OrderByDescending(v => v.Id).First();
                var getvalue = getLastId.Id;
                var num = Convert.ToInt32(getvalue.Substring(14));
                num += 1;
                _medicalHistory.Id = string.Concat("MedicalHistory", num);
            }
            catch
            {
                _medicalHistory.Id = "MedicalHistory1";
            }
            return _medicalHistory.Id;
        }

        public void Insert(string id,string patientid,string description)
        {
            var insert = new Hospital_Entity_Framework.MedicalHistory() 
            {
                Id = id,
                PatientId=patientid,
                Description =description,
            };
            _db.MedicalHistories.Add(insert);
            _db.SaveChanges();
        }

        public void Update(string id, string patientid , string description)
        {
            var update = _db.MedicalHistories.Single(v => v.Id == id);
            update.PatientId = patientid;
            update.Description = description;
            _db.MedicalHistories.AddOrUpdate(update);
            _db.SaveChanges();
        }

        public void Delete(string id)
        {
            var delete = _db.MedicalHistories.Single(vid => vid.Id == id);
            _db.MedicalHistories.Remove(delete);
            _db.SaveChanges();
        }

        public object Show()
        {
            var getestimate = from v in _db.MedicalHistories 
                select new
                {
                    v.Id,
                    v.PatientId,
                    v.Description,
                };
            _bs.DataSource = getestimate.ToList();
            return _bs;
        }
    }
    }

