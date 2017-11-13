using System;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Windows.Forms;
using Hospital_Entity_Framework;

namespace PatientManagement.Class
{
    public class Patient
    {
        private  HospitalDbContext _db = new HospitalDbContext();
        private  BindingSource _binding = new BindingSource();

        public void Insert(string name, string gender, DateTime dob, byte age, string address, string phone1,
            string phone2,
            string email, short weigh, short heigh)
        {
                var insert = new Hospital_Entity_Framework.Patient()
                {
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

        public void Update(int id, string name, string gender, DateTime dob, byte age, string address, string phone1,
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
                             where v.Name.Contains(text) || v.Phone1.Contains(text) || v.Phone2.Contains(text) || v.Email.Contains(text)
                select new
                {
                    v.Id,
                    v.Name,
                    v.Gender,
                    v.Age,
                    v.Address,
                    v.Phone1,
                    v.Email,
                };

            _binding.DataSource = getpatient.ToList();
            return _binding;
        }

        public void Check_Control(string name, string gender, string address, string phone1, string weigh,
            string heigh)
        {
            if (name == "")
            {
                MessageBox.Show(@"Please fill Name");
            }
            if (gender == "")
            {
                MessageBox.Show(@"Please fill Gender");
            }
            if (address == "")
            {
                MessageBox.Show(@"Please fill address");
            }
            if (phone1 == "")
            {
                MessageBox.Show(@"Please fill Phone1");
            }
            if (weigh == "")
            {
                MessageBox.Show(@"Please fill Weigh");
            }
            if (heigh == "")
            {
                MessageBox.Show(@"Please fill heigh");
            }
        }

        public Hospital_Entity_Framework.Patient Select(int id)
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
                    var patient=new Hospital_Entity_Framework.Patient(){
                        Id = item.Id,
                        Name = item.Name,
                        Gender = item.Gender,
                        DOB = item.DOB,
                        Age = item.Age,
                        Address = item.Address,
                        Phone1 = item.Phone1,
                        Phone2 = item.Phone2,
                        Email = item.Email,
                        Weight = item.Weight,
                        Height = item.Height,
                    };
                    return patient;
                }
            
            return null;
        }

        public object ShowAll()
        {
            var show = _db.Patients;

            _binding.DataSource = show.Select(v => new {v.Id, v.Name,v.Gender, v.Age, v.Address, v.Phone1, v.Email}).ToList();

            return _binding;
        }
    }

}

