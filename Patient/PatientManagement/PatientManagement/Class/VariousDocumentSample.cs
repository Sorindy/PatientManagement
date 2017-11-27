﻿using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Windows.Forms;
using Hospital_Entity_Framework;
using PatientManagement.Interface;

/*using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;*/

namespace PatientManagement.Class
{
   public class VariousDocumentSample: ISample
   {
       
        private readonly HospitalDbContext _db = new HospitalDbContext();
        private readonly BindingSource _bs = new BindingSource();

        public void Insert(string title, string description,int categoryid)
        {
            var insert = new Hospital_Entity_Framework.VariousDocumentSample() 
            {
                Title=title,
                Description=description,
                CategroyId=categoryid,
            };
            _db.VariousDocumentSamples.Add(insert);
            _db.SaveChanges();
        }

       public void Update(int id, string title, string description,int categoryid)
        {
            var update = _db.VariousDocumentSamples.Single(v => v.Id == id);
            update.Title = title;
            update.Description = description;
            update.CategroyId = categoryid;
            _db.VariousDocumentSamples.AddOrUpdate(update);
            _db.SaveChanges();
        }

        public void Delete(int id)
        {
            var delete = _db.VariousDocumentSamples.Single(vid => vid.Id == id);
            _db.VariousDocumentSamples.Remove(delete);
            _db.SaveChanges();
        }
       public string Path(int id)
       {
           var getPath = _db.VariousDocumentSamples.First(v => v.Id == id);
           return getPath.Description;
       }

        public object Show()
        {
            var getsample = from v in _db.VariousDocumentSamples 
                select new
                {
                    v.Id,
                    v.Title,
                    v.VariousDocumentCategory.Name,
                    v.Description,
                };
            _bs.DataSource = getsample.ToList();
            return _bs;
        }

       public object Show_Sample_Title()
       {
           var getsample = _db.VariousDocumentSamples.Select(v => v.Title);
           return getsample.ToList();
       }

       public string Search_Title(string title)
       {
           var getsample = _db.VariousDocumentSamples.Single(v => v.Title == title);
           return getsample.Description;
       }

       public Dictionary<int, string> ShowDictionary(int categoryId)
       {
           var getTitle = _db.VariousDocumentSamples.Where(v => v.CategroyId == categoryId);
           var dic=new Dictionary<int,string>();
           foreach (var item in getTitle)
           {
               dic.Add(item.Id,item.Title);
           }
           return dic;
       }
   }
}
