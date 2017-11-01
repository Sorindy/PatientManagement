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
        private BindingSource _bs = new BindingSource();
        private int _workerId;

        public void Insert(string name)
        {
            var insert = new Hospital_Entity_Framework.VariousDocumentCategory()
            {
                Name = name,
            };
            _db.VariousDocumentCategories.Add(insert);
            _db.SaveChanges();
        }

        public void Update(int id, string name)
        {
            var update = _db.VariousDocumentCategories.Single(v => v.Id == id);
            update.Name = name;
            _db.VariousDocumentCategories.AddOrUpdate(update);
            _db.SaveChanges();
        }

        public void Delete(int id)
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

        public object Show_Category_Name()
        {
            var getcategory = _db.VariousDocumentCategories.Select(v => v.Name);
            return getcategory.ToList();
        }

        public int Search_Id(string name)
        {
            var getcategory = _db.VariousDocumentCategories.Single(v => v.Name == name);
            return getcategory.Id;
        }

        public GroupBox ShowCategoryBox(int workerId)
        {
            _workerId = workerId;
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
                var singleOrDefault = _db.Managements.SingleOrDefault(v => v.Account.WorkerId == workerId);
                var checkCategory = singleOrDefault != null && singleOrDefault.ConsultationCategories
                                        .Any(v => v.Name == item.Name);

                if (checkCategory)
                {
                    var insert = new TempManagement { WorkerId = _workerId, Forms = "Medical's Form", Services = "VariousDocument", Categorys = item.Name };
                    _db.TempManagements.Add(insert);
                    _db.SaveChanges();
                }
                var checking = _db.TempManagements.Any(v => v.Categorys == item.Name);
                if (checking)
                {
                    var checkBox = new CheckBox();
                    checkBox.Size = new Size(251, 29);
                    checkBox.Location = new Point(27, 71);
                    checkBox.Text = item.Name;
                    checkBox.Checked = true;
                    flpn.Controls.Add(checkBox);
                    checkBox.CheckedChanged += CheckedValue;
                }
                else
                {
                    var checkBox = new CheckBox();
                    checkBox.Size = new Size(251, 29);
                    checkBox.Location = new Point(27, 71);
                    checkBox.Text = item.Name;
                    checkBox.Checked = false;
                    flpn.Controls.Add(checkBox);
                    checkBox.CheckedChanged += UnCheckedValue;
                }
            }

            flpn.Controls.Add(checkListBox);
            groupBox.Controls.Add(flpn);

            return groupBox;
        }

        private void CheckedValue(object sender, EventArgs e)
        {
            var get = (CheckBox)sender;
            var getValue = get.Text;
            var input = new TempManagement { WorkerId = _workerId, Forms = "Medical's Form", Services = "VariousDocument", Categorys = getValue };
            _db.TempManagements.Add(input);
            _db.SaveChanges();

            var medicalPanel = new Management();
            medicalPanel.MedicalPanel();
        }

        private void UnCheckedValue(object sender, EventArgs e)
        {
            var check = (CheckBox)sender;
            var getCategoryName = check.Text;

            var delete = _db.TempManagements.Single(v => v.Categorys == getCategoryName);
            _db.TempManagements.Remove(delete);
            _db.SaveChanges();

            var medicalPanel = new Management();
            medicalPanel.MedicalPanel();
        }
    }
}
