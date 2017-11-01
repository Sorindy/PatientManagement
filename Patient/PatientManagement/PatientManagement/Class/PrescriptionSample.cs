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
   public class PrescriptionSample : ISample
   {
       
        private HospitalDbContext _db = new HospitalDbContext();
        private BindingSource _bs = new BindingSource();

        public void Insert(string title, string description, int categoryid)
        {
            var insert = new Hospital_Entity_Framework.PrescriptionSample() 
            {
                Title=title,
                Description=description,
                CategoryId=categoryid,
            };
            _db.PrescriptionSamples.Add(insert);
            _db.SaveChanges();
        }

        public void Update(int id, string title, string description, int categoryid)
        {
            var update = _db.PrescriptionSamples.Single(v => v.Id == id);
            update.Title = title;
            update.Description = description;
            update.CategoryId = categoryid;
            _db.PrescriptionSamples.AddOrUpdate(update);
            _db.SaveChanges();
        }

        public void Delete(int id)
        {
            var delete = _db.PrescriptionSamples.Single(vid => vid.Id == id);
            _db.PrescriptionSamples.Remove(delete);
            _db.SaveChanges();
        }

        public object Show()
        {
            var getsample = from v in _db.PrescriptionSamples 
                select new
                {
                    v.Id,
                    v.Title,
                    v.PrescriptionCategory.Name,
                    v.Description,
                };
            _bs.DataSource = getsample.ToList();
            return _bs;
        }

       public object Show_Sample_Title()
       {
           var getsample = _db.PrescriptionSamples.Select(v => v.Title);
           return getsample.ToList();
       }

       public string Search_Title(string title)
       {
           var getsample = _db.PrescriptionSamples.Single(v => v.Title == title);
           return getsample.Description;
       }

    }
}
