using System;
using System.Linq;
using Hospital_Entity_Framework;

namespace PatientManagement.Class
{
    class MedicalRecord
    {
        private HospitalDbContext _db = new HospitalDbContext();
        private Hospital_Entity_Framework.MedicalRecord  _medicalRecord  = new Hospital_Entity_Framework.MedicalRecord();

        public string AutoId()
        {
            try
            {
                var getLastId = _db.MedicalRecords.OrderByDescending(v => v.Id.Length).First();
                var getvalue = getLastId.Id;
                var num = Convert.ToInt32(getvalue.Substring(13));
                num += 1;
                _medicalRecord.Id = string.Concat("MedicalRecord", num);
            }
            catch
            {
                _medicalRecord.Id = "MedicalRecord1";
            }
            return _medicalRecord.Id;
        }

        public void Insert(string id, string patientid)
        {
            var insert = new Hospital_Entity_Framework.MedicalRecord()
            {
                Id = id,
                PatientId  = patientid ,
            };
            _db.MedicalRecords.Add(insert);
            _db.SaveChanges();
        }

    }
}
