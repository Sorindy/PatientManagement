using System;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Windows.Forms;
using Hospital_Entity_Framework;

namespace PatientManagement.Class
{
    public class Worker
    {
        private readonly HospitalDbContext _db=new HospitalDbContext();
        public void Insert(string fname,string lname, string gender, DateTime dob, short age, string address,
            string phone1, string phone2, string email, string position, int salary, DateTime workdate)
        {
            var insert=new Hospital_Entity_Framework.Worker()
            {
               FirstName = fname,LastName = lname,Gender = gender,DOB = dob,Age = age,Address = address,
                Phone1 = phone1,Phone2 = phone2,Email = email,Position = position,Salary = salary,StartWorkDate = workdate,Hire = true
            };

            _db.Workers.Add(insert);
            _db.SaveChanges();
        }

        public void Delete(int id)
        {
            var delete = _db.Workers.Single(v=>v.Id==id);
            delete.Hire = false;

            _db.Workers.AddOrUpdate(delete);
            _db.SaveChanges();
        }

        public void Update(int id, string fname,string lname, string gender, DateTime dob, short age, string address,
            string phone1, string phone2, string email, string position, int salary, DateTime workdate)
        {
            var update = _db.Workers.Single(v => v.Id == id);
            update.FirstName = fname;
            update.LastName = lname;
            update.Gender = gender;
            update.DOB = dob;
            update.Age = age;
            update.Address = address;
            update.Phone1 = phone1;
            update.Phone2 = phone2;
            update.Email = email;
            update.Position = position;
            update.Salary = salary;
            update.StartWorkDate = workdate;

            _db.Workers.AddOrUpdate(update);
            _db.SaveChanges();
        }

        public object ShowAll()
        {      
            var bs=new BindingSource();

                var showdata = _db.Workers;
                bs.DataSource = showdata.Where(v=>v.Position!="Admin").Where(v=>v.Hire).Select(v => new
                {
                    v.Id,
                    v.FirstName,v.LastName,
                    v.Gender,
                    v.Age,
                    v.Phone1,
                    v.Email,
                    v.Position,
                }).ToList();
                return bs;
        }

        public Hospital_Entity_Framework.Worker SelectedWorker(int id)
        {
            var getWorker = _db.Workers.Single(v => v.Id == id);
            return getWorker;
        }

        public object Search(string text)
        {
            var bs=new BindingSource();
            var list = _db.Workers.Where(v=>v.Position!="Admin"&&v.Hire).ToList();
            var search = list.Where(v => v.FirstName.Contains(text) ||
                                                v.LastName.Contains(text)||
                                                v.Phone1.Contains(text) || 
                                                v.Phone2.Contains(text)||
                                                v.Position.Contains(text)||
                                                v.Gender.Contains(text));
            return bs.DataSource = search.Select(v=>new{v.Id,v.FirstName,v.LastName,v.Gender,v.Age,v.Phone1,v.Email,v.Position}).ToList();
        }

        public Hospital_Entity_Framework.Account Account(int workerId)
        {
            if (_db.Accounts.Any(v => v.WorkerId == workerId))
            {
                var search = _db.Accounts.First(v => v.WorkerId == workerId);
                return search;
            }
            else
            {
                MessageBox.Show(@"Please create account before add category to doctor.", @"Error");
                return null;
            }
        }
    }
}
