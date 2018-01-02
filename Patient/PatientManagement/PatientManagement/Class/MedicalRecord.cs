using System.Collections.Generic;
using System.Linq;
using Hospital_Entity_Framework;

namespace PatientManagement.Class
{
  public   class MedicalRecord
    {
        private readonly HospitalDbContext _db = new HospitalDbContext();

        public void Insert(int patientid)
        {
            var insert = new Hospital_Entity_Framework.MedicalRecord()
            {
                PatientId  = patientid
            };
            _db.MedicalRecords.Add(insert);
            _db.SaveChanges();
        }

        public Dictionary<int, string> ShowNurse()
        {
            var dic=new Dictionary<int,string>();
            var getNurse = _db.Workers.Where(v => v.Position == "Nurse" && v.Hire);
            foreach (var item in getNurse)
            {
                dic.Add(item.Id,item.LastName);
            }
            return dic;
        }

        public Dictionary<int, string> ShowReferrer()
        {
            var dic=new Dictionary<int,string>();
            var getReferrer = _db.Referrers;
            foreach (var item in getReferrer)
            {
                dic.Add(item.Id,item.LastName);
            }
            return dic;
        }

        public Referrer ShowDetail(int id)
        {
            var getReferrer = _db.Referrers.First(v => v.Id == id);
            return getReferrer;
        }
    }
}
