using System;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Windows.Forms;
using Hospital_Entity_Framework;

namespace PatientManagement.Class
{
    public class Patient
    {
        private readonly HospitalDbContext _db = new HospitalDbContext();
        private readonly BindingSource _binding = new BindingSource();

        public void Insert(string fname,string lname,string khname, string gender, DateTime dob, byte age, string address, string phone1,
            string phone2,
            string email, short weigh, short heigh)
        {
            var insert = new Hospital_Entity_Framework.Patient()
            {
                PatientIdentify = Convert.ToInt64
                (DateTime.Today.Day.ToString("D2") + DateTime.Today.Month.ToString("D2") + DateTime.Today.Year%100 + DateTime.Now.Hour.ToString("D2") + DateTime.Now.Minute.ToString("D2") + DateTime.Now.Millisecond.ToString("D2")),
                FirstName = fname,
                LastName = lname,
                KhmerName = khname,
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

        public Hospital_Entity_Framework.Patient InsertAndGet(string fname, string lname, string khname, string gender, DateTime dob, byte age, string address, string phone1,
            string phone2,
            string email, short weigh, short heigh)
        {
            var insert = new Hospital_Entity_Framework.Patient()
            {
                PatientIdentify = Convert.ToInt64
                    (DateTime.Today.Day.ToString("D2") + DateTime.Today.Month.ToString("D2") + DateTime.Today.Year%100 + DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Millisecond.ToString()),
                FirstName = fname,
                LastName = lname,
                KhmerName = khname,
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

            return insert;
        }

        public void Update(int id, string fname,string lname,string khname, string gender, DateTime dob, byte age, string address, string phone1,
            string phone2, string email, short weigh, short heigh)
        {
            var update = _db.Patients.Single(v => v.Id == id);
            update.FirstName = fname;
            update.LastName = lname;
            update.KhmerName = khname;
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
            if (!string.IsNullOrEmpty(text))
            {
                var patientList = _db.Patients.ToList();
                var patients = patientList.Where(v => v.KhmerName.ToLower().Contains(text.ToLower())
                                                      || v.Phone1.Contains(text) || v.Phone2.Contains(text) ||
                                                      v.Email.Contains(text) ||
                                                      v.PatientIdentify.ToString().Contains(text)
                                                      || v.FirstName.Contains(text) || v.LastName.Contains(text));
                              
                               
                _binding.DataSource = patients.Select(v=> new
                {
                    v.Id,v.PatientIdentify,
                    v.FirstName,v.LastName,v.KhmerName,
                    v.Gender,
                    v.Age,
                    v.Address,
                    v.Phone1
                }).ToList();

            }
            else
            {
                _binding.DataSource = (from v in _db.Patients
                                       select new
                                       {
                                           v.Id,v.PatientIdentify,
                                           v.FirstName,v.LastName,v.KhmerName,
                                           v.Gender,
                                           v.Age,
                                           v.Address,
                                           v.Phone1
                                       }).ToList();
            }

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
            var select = _db.Patients.SingleOrDefault(v => v.Id == id);
            return select;
        }

        public object ShowAll()
        {
            var show = _db.Patients;

            _binding.DataSource = show.Select(v => new { v.Id,v.PatientIdentify, v.FirstName,v.LastName,v.KhmerName, v.Gender, v.Age, v.Address, v.Phone1 }).ToList();

            return _binding;
        }
    }

}

