using System;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Windows.Forms;
using Hospital_Entity_Framework;

/*using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;*/

namespace PatientManagement.Class
{
   public class VariousDocumentSample: ISample
   {
       
        private HospitalDbContext _db = new HospitalDbContext();
        private Hospital_Entity_Framework.VariousDocumentSample _variousDocumentSample = new Hospital_Entity_Framework.VariousDocumentSample();
        private BindingSource _bs = new BindingSource();

        public string AutoId()
        {
            try
            {
                var getLastId = _db.VariousDocumentSamples.OrderByDescending(v => v.Id).First();
                var getvalue = getLastId.Id;
                var num = Convert.ToInt32(getvalue.Substring(21));
                num += 1;
                _variousDocumentSample.Id = string.Concat("VariousDocumentSample", num);
            }
            catch
            {
                _variousDocumentSample.Id = "VariousDocumentSample1";
            }
            return _variousDocumentSample.Id;
        }

        public void Insert(string id, string title, string description)
        {
            var insert = new Hospital_Entity_Framework.VariousDocumentSample() 
            {
                Id = id,
                Title=title,
                Description=description,
            };
            _db.VariousDocumentSamples.Add(insert);
            _db.SaveChanges();
        }

        public void Update(string id, string title, string description)
        {
            var update = _db.VariousDocumentSamples.Single(v => v.Id == id);
            update.Title = title;
            update.Description = description;
            _db.VariousDocumentSamples.AddOrUpdate(update);
            _db.SaveChanges();
        }

        public void Delete(string id)
        {
            var delete = _db.VariousDocumentSamples.Single(vid => vid.Id == id);
            _db.VariousDocumentSamples.Remove(delete);
            _db.SaveChanges();
        }

        public object Show()
        {
            var getsample = from v in _db.VariousDocumentSamples 
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
           var getsample = _db.VariousDocumentSamples.Select(v => v.Title);
           return getsample.ToList();
       }

       public string Search_Title(string title)
       {
           var getsample = _db.VariousDocumentSamples.Single(v => v.Title == title);
           return getsample.Description;
       }

    }
}
