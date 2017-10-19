using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Hospital_Entity_Framework;
using PatientManagement.Interface;

namespace PatientManagement.Class
{
   
    public  class ConsultationCategory : ICategory
    {

        private HospitalDbContext _db = new HospitalDbContext();
        private BindingSource _bs = new BindingSource();

        public void Insert(string name)
        {
            var insert = new Hospital_Entity_Framework.ConsultationCategory()
            {
                Name = name,
            };
            _db.ConsultationCategories.Add(insert);
            _db.SaveChanges();
        }

        public void Update(int id, string name)
        {
            var update = _db.ConsultationCategories.Single(v => v.Id == id);
            update.Name = name;
            _db.ConsultationCategories.AddOrUpdate(update);
            _db.SaveChanges();
        }

        public void Delete(int id)
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

            groupBox.Text = @"Consutation";
            var getCategroy = from v in _db.ConsultationCategories select new { v.Name };
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
