﻿using System;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Windows.Forms;
using Hospital_Entity_Framework;

namespace PatientManagement.Class
{
    public class Worker
    {
        private readonly HospitalDbContext _db=new HospitalDbContext();
        public Account Account { get; set; }

        public void Insert(string name, string gender, DateTime dob, short age, string address,
            string phone1, string phone2, string email, string position, int salary, DateTime workdate)
        {
            var insert=new Hospital_Entity_Framework.Worker()
            {
                Name = name,Gender = gender,DOB = dob,Age = age,Address = address,
                Phone1 = phone1,Phone2 = phone2,Email = email,Position = position,Salary = salary,StartWorkDate = workdate
            };

            _db.Workers.Add(insert);
            _db.SaveChanges();
        }

        public void Delete(int id)
        {
            var delete = _db.Workers.Single(v=>v.Id==id);

            _db.Workers.Remove(delete);
            _db.SaveChanges();
        }

        public void Update(int id, string name, string gender, DateTime dob, short age, string address,
            string phone1, string phone2, string email, string position, int salary, DateTime workdate)
        {
            var update = _db.Workers.Single(v => v.Id == id);
            update.Name = name;
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
            BindingSource bs=new BindingSource();

                var showdata = _db.Workers;
                bs.DataSource = showdata.Select(v => new
                {
                    v.Id,
                    v.Name,
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
            BindingSource bs=new BindingSource();

            var search = _db.Workers.Where(v => v.Name.Contains(text) ||
                                                v.Phone1.Contains(text) || 
                                                v.Phone2.Contains(text)||
                                                v.Position.Contains(text)||
                                                v.Gender.Contains(text));
            return bs.DataSource = search.Select(v=>new{v.Id,v.Name,v.Gender,v.Age,v.Phone1,v.Email,v.Position}).ToList();
        }

    }
}
