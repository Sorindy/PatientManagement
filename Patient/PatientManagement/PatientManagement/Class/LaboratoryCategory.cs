using System;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Hospital_Entity_Framework;
using PatientManagement.Interface;

namespace PatientManagement.Class
{
   public  class LaboratoryCategory: ICategory 
    {
        private HospitalDbContext _db = new HospitalDbContext();
        private Hospital_Entity_Framework.LaboratoryCategory   _laboratoryCategory  = new Hospital_Entity_Framework.LaboratoryCategory();
        private BindingSource _bs = new BindingSource();

        public string AutoId()
        {
            try
            {
                var getLastId = _db.LaboratoryCategories.OrderByDescending(v => v.Id.Length).First();
                var getvalue = getLastId.Id;
                var num = Convert.ToInt32(getvalue.Substring(18));
                num += 1;
                _laboratoryCategory.Id = string.Concat("LaboratoryCategory", num);
            }
            catch
            {
                _laboratoryCategory.Id = "LaboratoryCategory1";
            }
            return _laboratoryCategory.Id;
        }

        public void Insert(string id, string name)
        {
            var insert = new Hospital_Entity_Framework.LaboratoryCategory()
            {
                Id = id,
                Name = name,
            };
            _db.LaboratoryCategories.Add(insert);
            _db.SaveChanges();
        }

        public void Update(string id, string name)
        {
            var update = _db.LaboratoryCategories.Single(v => v.Id == id);
            update.Name = name;
            _db.LaboratoryCategories.AddOrUpdate(update);
            _db.SaveChanges();
        }

        public void Delete(string id)
        {
            var delete = _db.LaboratoryCategories.Single(vid => vid.Id == id);
            _db.LaboratoryCategories.Remove(delete);
            _db.SaveChanges();
        }

        public object Show()
        {
            var getcategory = from v in _db.LaboratoryCategories
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
            var flpn = new FlowLayoutPanel
            {
                FlowDirection = FlowDirection.TopDown,
                Dock = DockStyle.Fill,
                Size = new Size(508, 54),
                AutoScroll = true
            };
            groupBox.Size = new Size(520, 100);
            checkListBox.Size = new Size(508, 54);

            groupBox.Text = @"Laboratory";
            var getCategroy = from v in _db.LaboratoryCategories select new { v.Name };
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
