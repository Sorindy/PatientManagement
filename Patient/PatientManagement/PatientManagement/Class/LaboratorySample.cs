﻿using System.Data.Entity.Migrations;
using System.Linq;
using System.Windows.Forms;
using Hospital_Entity_Framework;
using PatientManagement.Interface;

/*using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;*/

namespace PatientManagement.Class
{
   public class LaboratorySample : ISample
   {
        
        private HospitalDbContext _db = new HospitalDbContext();
        private BindingSource _bs = new BindingSource();

        public void Insert(string title, string description)
        {
            var insert = new Hospital_Entity_Framework.LaboratorySample()
            {
                Title=title,
                Description=description,
            };
            _db.LaboratorySamples.Add(insert);
            _db.SaveChanges();
        }

        public void Update(int id, string title, string description)
        {
            var update = _db.LaboratorySamples.Single(v => v.Id == id);
            update.Title = title;
            update.Description = description;
            _db.LaboratorySamples.AddOrUpdate(update);
            _db.SaveChanges();
        }

        public void Delete(int id)
        {
            var delete = _db.LaboratorySamples.Single(vid => vid.Id == id);
            _db.LaboratorySamples.Remove(delete);
            _db.SaveChanges();
        }

        public object Show()
        {
            var getsample = from v in _db.LaboratorySamples 
                select new
                {
                    v.Id,
                    v.Title,
                    v.Description,
                };
            _bs.DataSource = getsample.ToList();
            return _bs;
        }

       public object Show_Sample_Title()
       {
           var getsample = _db.LaboratorySamples.Select(v => v.Title);
           return getsample.ToList();
       }

       public string Search_Title(string title)
       {
           var getsample = _db.LaboratorySamples.Single(v => v.Title == title);
           return getsample.Description;
       }

   }
}
