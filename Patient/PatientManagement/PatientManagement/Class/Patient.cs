using System;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Windows.Forms;
using Hospital_Entity_Framework;
/*using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;*/


namespace  PatientManagement
{
    public class Patient
    {
        private HospitalDbContext _db = new HospitalDbContext();
        private BindingSource _binding = new BindingSource();
        private Hospital_Entity_Framework.Patient _patient = new Hospital_Entity_Framework.Patient();

        public void Insert(string id, string name, string gender, DateTime dob, byte age, string address, string phone1,
            string phone2,
            string email, short weigh, short heigh)
        {
                var insert = new Hospital_Entity_Framework.Patient()
                {
                    Id = id,
                    Name = name,
                    Gender = gender,
                    DOB = dob,
                    Age = age,
                    Address = address,
                    Phone1 = phone1,
                    Phone2 = phone2,
                    Email = email,
                    Weight = weigh,
                    Height = heigh,
                };
                _db.Patients.Add(insert);
                _db.SaveChanges();
        }

        public void Update(string id, string name, string gender, DateTime dob, byte age, string address, string phone1,
            string phone2, string email, short weigh, short heigh)
        {
            var update = _db.Patients.Single(v => v.Id == id);
            update.Name = name;
            update.Gender = gender;
            update.DOB = dob;
            update.Age = age;
            update.Address = address;
            update.Phone1 = phone1;
            update.Phone2 = phone2;
            update.Email = email;
            update.Weight = weigh;
            update.Height = heigh;
            _db.Patients.AddOrUpdate(update);
            _db.SaveChanges();
        }

        public object Search(string text)
        {
            var getpatient = from v in _db.Patients
                where v.Id == text || v.Name == text || v.Phone1 == text || v.Phone2 == text || v.Email == text
                select new
                {
                    v.Id,
                    v.Name,
                    v.Gender,
                    v.DOB,
                    v.Age,
                    v.Address,
                    v.Phone1,
                    v.Phone2,
                    v.Email,
                    v.Weight,
                    v.Height,
                };

            _binding.DataSource = getpatient.ToList();
            return _binding;
        }

        public void Cheack_Control(string name, string gender, string address, string phone1, string weigh,
            string heigh)
        {
            if (name == "")
            {
                MessageBox.Show("Please fill Name");
            }
            if (gender == "")
            {
                MessageBox.Show("Please fill Gender");
            }
            if (address == "")
            {
                MessageBox.Show("Please fill address");
            }
            if (phone1 == "")
            {
                MessageBox.Show("Please fill Phone1");
            }
            if (weigh == "")
            {
                MessageBox.Show("Please fill Weigh");
            }
            if (heigh == "")
            {
                MessageBox.Show("Please fill heigh");
            }
        }

        public string AutoId()
        {
            try
            {
                var getLastId = _db.Patients.OrderByDescending(v => v.Id).First();
                var getvalue = getLastId.Id;
                var num = Convert.ToInt32(getvalue.Substring(7));
                num += 1;
                _patient.Id = string.Concat("Patient", num);
            }
            catch
            {
                _patient.Id = "Patient1";
            }
            return _patient.Id;
        }

        public Hospital_Entity_Framework.Patient Select(string id)
        {
            
                var getpatient = from v in _db.Patients
                    where v.Id == id
                    select new
                    {
                        v.Id,
                        v.Name,
                        v.Gender,
                        v.DOB,
                        v.Age,
                        v.Address,
                        v.Phone1,
                        v.Phone2,
                        v.Email,
                        v.Weight,
                        v.Height,
                    };
                foreach (var item in getpatient)
                {
                    _patient.Id = item.Id;
                    _patient.Name = item.Name;
                    _patient.Gender = item.Gender;
                    _patient.DOB = item.DOB;
                    _patient.Age = item.Age;
                    _patient.Address = item.Address;
                    _patient.Phone1 = item.Phone1;
                    _patient.Phone2 = item.Phone2;
                    _patient.Email = item.Email;
                    _patient.Weight = item.Weight;
                    _patient.Height = item.Height;
                }
            
            return _patient;
        }
    }

}

