using System.Data.Entity.Migrations;
using Hospital_Entity_Framework;
using System.Linq;

namespace PatientManagement.Class
{
    public class MedicalHistory
    {

        private readonly HospitalDbContext _db = new HospitalDbContext();

        public void Insert(int patientid, string description)
        {
            var insert = new Hospital_Entity_Framework.MedicalHistory()
            {
                PatientId = patientid,
                Description = description,
            };
            _db.MedicalHistories.Add(insert);
            _db.SaveChanges();
        }

        public void Update(int id, string description)
        {
            var update = _db.MedicalHistories.Single(v => v.Id == id);
            update.Description = description;
            _db.MedicalHistories.AddOrUpdate(update);
            _db.SaveChanges();
        }

        public Hospital_Entity_Framework.MedicalHistory Show_medicalhistory(int patientId)
        {
            var getMedicalHistory = _db.MedicalHistories.First(v => v.PatientId == patientId);
            return getMedicalHistory;
        }
    }
}

