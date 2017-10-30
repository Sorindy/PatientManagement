using System;
using System.Linq;
using Hospital_Entity_Framework;

namespace PatientManagement.Class
{
    class MedicalRecord
    {
        private readonly HospitalDbContext _db = new HospitalDbContext();

        public void Insert(int patientid)
        {
            var insert = new Hospital_Entity_Framework.MedicalRecord()
            {
                PatientId  = patientid ,
            };
            _db.MedicalRecords.Add(insert);
            _db.SaveChanges();
        }

    }
}
