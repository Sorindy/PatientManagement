using System;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Hospital_Entity_Framework;
using PatientManagement.Interface;

namespace PatientManagement.Class
{
   public  class VariousDocumentCategory: ICategory 
    {

        private HospitalDbContext _db = new HospitalDbContext();
        private Hospital_Entity_Framework.VariousDocumentCategory  _variousDocumentCategory= new Hospital_Entity_Framework.VariousDocumentCategory();
        private BindingSource _bs = new BindingSource();

        public string AutoId()
        {
            try
            {
                var getLastId = _db.VariousDocumentCategories.OrderByDescending(v => v.Id.Length).First();
                var getvalue = getLastId.Id;
                var num = Convert.ToInt32(getvalue.Substring(23));
                num += 1;
                _variousDocumentCategory.Id = string.Concat("VariousDocumentCategory", num);
            }
            catch
            {
                _variousDocumentCategory.Id = "VariousDocumentCategory1";
            }
            return _variousDocumentCategory.Id;
        }

        public void Insert(string id, string name)
        {
            var insert = new Hospital_Entity_Framework.VariousDocumentCategory()
            {
                Id = id,
                Name = name,
            };
            _db.VariousDocumentCategories.Add(insert);
            _db.SaveChanges();
        }

        public void Update(string id, string name)
        {
            var update = _db.VariousDocumentCategories.Single(v => v.Id == id);
            update.Name = name;
            _db.VariousDocumentCategories.AddOrUpdate(update);
            _db.SaveChanges();
        }

        public void Delete(string id)
        {
            var delete = _db.VariousDocumentCategories.Single(vid => vid.Id == id);
            _db.VariousDocumentCategories.Remove(delete);
            _db.SaveChanges();
        }

        public object Show()
        {
            var getcategory = from v in _db.VariousDocumentCategories
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

            groupBox.Text = @"VariousDocument";
            var getCategroy = from v in _db.VariousDocumentCategories select new { v.Name };
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
