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
                dic.Add(item.Id,item.FirstName+" "+ item.LastName);
            }
            return dic;
        }

        public Dictionary<int, string> SearchNurse(string text)
        {
            var dic=new Dictionary<int,string>();
            var getNurse = _db.Workers.Where(v => v.Position == "Nurse" && v.Hire).Where(v=>v.FirstName.ToLower().Contains(text)||
                v.LastName.ToLower().Contains(text));
            foreach (var item in getNurse)
            {
                dic.Add(item.Id, item.FirstName + " " + item.LastName);
            }
            return dic;
        }

        public Referrer ShowDetail(int id)
        {
            var getReferrer = _db.Referrers.First(v => v.Id == id);
            return getReferrer;
        }

        public Dictionary<int, string> SearchRefferer(string text)
        {
            var getrefferer = _db.Referrers.Where(v => v.FirstName.ToLower().Contains(text) || v.LastName.ToLower().Contains(text)).ToList();
            var dic = new Dictionary<int, string>();
            foreach (var item in getrefferer)
            {
                dic.Add(item.Id, item.FirstName + " " + item.LastName);
            }
            return dic;
        }

        public Dictionary<int, string> DicAllRefferer()
        {
            var getrefferer = _db.Referrers.ToList();
            var dic = new Dictionary<int, string>();
            foreach (var item in getrefferer)
            {
                dic.Add(item.Id, item.FirstName + " " + item.LastName);
            }
            return dic;
        }

    }
}
