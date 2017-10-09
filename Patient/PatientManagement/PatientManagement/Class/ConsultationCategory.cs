using System;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Windows.Forms;
using Hospital_Entity_Framework;

namespace PatientManagement.Class
{
   
    public  class ConsultationCategory : ICategory
    {

        private HospitalDbContext _db = new HospitalDbContext();
        private Hospital_Entity_Framework.ConsultationCategory _consultationCategory =new Hospital_Entity_Framework.ConsultationCategory();
        private BindingSource _bs = new BindingSource();

        public string AutoId()
        {
            try
            {
                var getLastId = _db.ConsultationCategories.OrderByDescending(v => v.Id).First();
                var getvalue = getLastId.Id;
                var num = Convert.ToInt32(getvalue.Substring(20));
                num += 1;
                _consultationCategory.Id = string.Concat("ConsultationCategory", num);
            }
            catch
            {
                _consultationCategory.Id = "ConsultationCategory1";
            }
            return _consultationCategory.Id;
        }

        public void Insert(string id, string name)
        {
            var insert = new Hospital_Entity_Framework.ConsultationCategory()
            {
                Id = id,
                Name = name,
            };
            _db.ConsultationCategories.Add(insert);
            _db.SaveChanges();
        }

        public void Update(string id, string name)
        {
            var update = _db.ConsultationCategories.Single(v => v.Id == id);
            update.Name = name;
            _db.ConsultationCategories.AddOrUpdate(update);
            _db.SaveChanges();
        }

        public void Delete(string id)
        {
            var delete = _db.ConsultationCategories.Single(vid => vid.Id == id);
            _db.ConsultationCategories.Remove(delete);
            _db.SaveChanges();
        }

        public object Show()
        {
            var getcategory = from v in _db.ConsultationCategories
                select new
                {
                    v.Id,
                    v.Name,
                };
            _bs.DataSource = getcategory.ToList();
            return _bs;
        }
    }
}
