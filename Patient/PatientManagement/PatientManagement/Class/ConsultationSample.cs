﻿using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Windows.Forms;
using Hospital_Entity_Framework;
using PatientManagement.Interface;

namespace PatientManagement.Class
{
   public class ConsultationSample: ISample
   {
        
        private readonly HospitalDbContext _db = new HospitalDbContext();
        private readonly  BindingSource _bs = new BindingSource();

        public void Insert(string title, string description, int categoryid)
        {
            var insert = new Hospital_Entity_Framework.ConsultationSample()
            {
                Title=title,
                Description=description,
                CategoryId=categoryid,
            };
            _db.ConsultationSamples.Add(insert);
            _db.SaveChanges();
        }

        public void Update(int id, string title, string description,int categoryid)
        {
            var update = _db.ConsultationSamples.Single(v => v.Id == id);
            update.Id = id;
            update.Title = title;
            update.Description = description;
            update.CategoryId = categoryid;
            _db.ConsultationSamples.AddOrUpdate(update);
            _db.SaveChanges();
        }

        public void Delete(int id)
        {
            var delete = _db.ConsultationSamples.Single(vid => vid.Id == id);
            _db.ConsultationSamples.Remove(delete);
            _db.SaveChanges();
        }

       public object Show()
       {
           var getsample = from v in _db.ConsultationSamples
               select new
               {
                   v.Id,
                   v.Title,
                   v.ConsultationCategory.Name,
                   v.Description,
               };
           _bs.DataSource = getsample.ToList();
           return _bs;
       }

       public object Show_Sample_Title()
       {
           var getsample = _db.ConsultationSamples.Select(v=>v.Title);
           return getsample.ToList();
       }

       public string Search_Title(string title)
       {
           var getsample = _db.ConsultationSamples.ToList().Single(v => v.Title.ToLower().Contains(title));
           return getsample.Description;
       }

       public Dictionary<int, string> ShowDictionary(int categoryId)
       {
           var getTitle = _db.ConsultationSamples.Where(v => v.CategoryId == categoryId);
           var dic = new Dictionary<int, string>();
           foreach (var item in getTitle)
           {
               dic.Add(item.Id, item.Title);
           }
           return dic;
       }

       public TreeNode AddNodeToService()
       {
           var nodeService = new TreeNode
           {
               Name = "Consultation",
               Text = @"Consultation"
           };
           var getCategory = _db.ConsultationCategories.Where(v=>v.Available).ToList();
           foreach (var item in getCategory)
           {
               var nodeCat = new TreeNode
               {
                   Name = item.Id.ToString(),
                   Text = item.Name
               };
               var getSampleByCat = _db.ConsultationSamples.Where(v => v.CategoryId == item.Id).ToList();
               foreach (var sample in getSampleByCat)
               {
                   var node = new TreeNode
                   {
                       Name = sample.Id.ToString(),
                       Text = sample.Title
                   };
                   nodeCat.Nodes.Add(node);
               }
               nodeService.Nodes.Add(nodeCat);
           }
           return nodeService;
       }

       public Dictionary<Dictionary<Dictionary<string, int>, int>, string> SearchTitle(string title)
       {
           var searchAllSample = _db.ConsultationSamples.ToList()
               .Where(v => v.Title.ToLower().Contains(title.ToLower()));
           var dic = new Dictionary<Dictionary<Dictionary<string, int>, int>, string>(); 
           foreach (var item in searchAllSample)
           {
              var dicSer = new Dictionary<string, int> {{@"Consultation", item.CategoryId}};
              var dicCat = new Dictionary<Dictionary<string, int>, int> {{dicSer, item.Id}};
              dic.Add(dicCat,item.Title);
           }
           return dic;
       }

       public string Path(int id)
       {
           var getPath = _db.ConsultationSamples.First(v => v.Id == id);
           return getPath.Description;
       }

       public Dictionary<int, string> SearchTitle(int categoy, string title)
       {
           var get = _db.ConsultationSamples.Where(v => v.Title.ToLower().Contains(title) && v.CategoryId == categoy);
           return get.ToList().ToDictionary(item => item.Id, item => item.Title);
       }
   }
}
