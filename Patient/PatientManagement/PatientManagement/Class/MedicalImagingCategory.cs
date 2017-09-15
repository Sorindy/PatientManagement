using System;
using System.Windows.Forms;
using System.Data.Entity.Migrations;
using Hospital_Entity_Framework;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatientManagement.Class;

namespace PatientManagement
{
   public  class MedicalImagingCategory: ICategory 
    {
        private HospitalDbContext _db = new HospitalDbContext();
        private Hospital_Entity_Framework.MedicalImagingCategory  _medicalImagingCategory = new Hospital_Entity_Framework.MedicalImagingCategory();
        private BindingSource _bs = new BindingSource();

        public MedicalImagingCategory()
        {

        }

        public string AutoId()
        {
            try
            {
                var getLastId = _db.MedicalImagingCategories.OrderByDescending(v => v.Id).First();
                var getvalue = getLastId.Id;
                var num = Convert.ToInt32(getvalue.Substring(22));
                num += 1;
                _medicalImagingCategory.Id = string.Concat("MedicalImagingCategory", num);
            }
            catch
            {
                _medicalImagingCategory.Id = "VariousDocumentCategory1";
            }
            return _medicalImagingCategory.Id;
        }

        public void Insert(string id, string name)
        {
            var insert = new Hospital_Entity_Framework.MedicalImagingCategory()
            {
                Id = id,
                Name = name,
            };
            _db.MedicalImagingCategories.Add(insert);
            _db.SaveChanges();
        }

        public void Update(string id, string name)
        {
            var update = _db.MedicalImagingCategories.Single(v => v.Id == id);
            update.Name = name;
            _db.MedicalImagingCategories.AddOrUpdate(update);
            _db.SaveChanges();
        }

        public void Delete(string id)
        {
            var delete = _db.MedicalImagingCategories.Single(vid => vid.Id == id);
            _db.MedicalImagingCategories.Remove(delete);
            _db.SaveChanges();
        }

        public object Show()
        {
            var getcategory = from v in _db.MedicalImagingCategories
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
