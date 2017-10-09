using System;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Hospital_Entity_Framework;
using PatientManagement.Interface;

namespace PatientManagement.Class
{
   public  class PrescriptionCategory: ICategory 
    {
        private HospitalDbContext _db = new HospitalDbContext();

        private Hospital_Entity_Framework.PrescriptionCategory _prescriptionCategory =
            new Hospital_Entity_Framework.PrescriptionCategory();
        private BindingSource _bs = new BindingSource();

        public string AutoId()
        {
            try
            {
                var getLastId = _db.PrescriptionCategories.OrderByDescending(v => v.Id).First();
                var getvalue = getLastId.Id;
                var num = Convert.ToInt32(getvalue.Substring(20));
                num += 1;
                _prescriptionCategory.Id = string.Concat("PrescriptionCategory", num);
            }
            catch
            {
                _prescriptionCategory.Id = "PrescriptionCategory1";
            }
            return _prescriptionCategory.Id;
        }

        public void Insert(string id, string name)
        {
            var insert = new Hospital_Entity_Framework.PrescriptionCategory()
            {
                Id = id,
                Name = name,
            };
            _db.PrescriptionCategories.Add(insert);
            _db.SaveChanges();
        }

        public void Update(string id, string name)
        {
            var update = _db.PrescriptionCategories.Single(v => v.Id == id);
            update.Name = name;
            _db.PrescriptionCategories.AddOrUpdate(update);
            _db.SaveChanges();
        }

        public void Delete(string id)
        {
            var delete = _db.PrescriptionCategories.Single(vid => vid.Id == id);
            _db.PrescriptionCategories.Remove(delete);
            _db.SaveChanges();
        }

        public object Show()
        {
            var getcategory = from v in _db.PrescriptionCategories 
                select new
                {
                    v.Id,
                    v.Name,
                };
            _bs.DataSource = getcategory.ToList();
            return _bs;
        }

        public GroupBox ShowCategoryBox()
        {
            var checkListBox = new CheckedListBox();
            var groupBox = new GroupBox();
            var flpn = new FlowLayoutPanel()
            {
                FlowDirection = FlowDirection.TopDown,
                Dock = DockStyle.Fill
            };
            flpn.Size = new Size(508, 54);
            flpn.AutoScroll = true;
            groupBox.Size = new Size(520, 100);
            checkListBox.Size = new Size(508, 54);

            groupBox.Text = @"Presciption";
            var getCategroy = from v in _db.PrescriptionCategories select new { v.Name };
            foreach (var item in getCategroy)
            {
                checkListBox.Items.Add(item.Name);
            }

            flpn.Controls.Add(checkListBox);
            groupBox.Controls.Add(flpn);
            return groupBox;
        }
    }
}
