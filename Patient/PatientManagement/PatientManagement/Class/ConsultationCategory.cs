using System;
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

        private readonly HospitalDbContext _db = new HospitalDbContext();
        private readonly BindingSource _bs = new BindingSource();
        private int _workerId;
        public Management Management;

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

        public GroupBox ShowCategoryBox(int workerId)
        {
            _workerId = workerId;
            var groupBox = new GroupBox();
            var flpn = new FlowLayoutPanel
            {
                FlowDirection = FlowDirection.TopDown,
                Dock = DockStyle.Fill,
                Size = new Size(508, 54),
                AutoScroll = true
            };
            groupBox.Size = new Size(520, 100);

            groupBox.Text = @"Consutation";
            var getCategroy = from v in _db.ConsultationCategories select new { v.Name };
            
            foreach (var item in getCategroy)
            {
                var singleOrDefault = _db.Managements.SingleOrDefault(v => v.Account.WorkerId == workerId);
                var checkCategory = singleOrDefault != null && singleOrDefault.ConsultationCategories
                                        .Any(v => v.Name==item.Name);
                
                if (checkCategory)
                {
                    var insert=new TempManagement{WorkerId = _workerId,Forms = "Medical's Form",Services = "Consultation",Categorys = item.Name};
                    _db.TempManagements.Add(insert);
                    _db.SaveChanges();

                    var checking = _db.TempManagements.Any(v => v.Categorys == item.Name);
                    if (checking)
                    {
                        var checkBox = new CheckBox
                        {
                            Size = new Size(251, 29),
                            Location = new Point(27, 71),
                            Text = item.Name,
                            Checked = true
                        };
                        flpn.Controls.Add(checkBox);
                        checkBox.CheckedChanged += UnCheckedValue;
                    }
                    else
                    {
                        var checkBox = new CheckBox
                        {
                            Size = new Size(251, 29),
                            Location = new Point(27, 71),
                            Text = item.Name,
                            Checked = false
                        };
                        flpn.Controls.Add(checkBox);
                        checkBox.CheckedChanged += CheckedValue;
                    }
                }
                else
                {
                    var checking = _db.TempManagements.Any(v => v.Categorys == item.Name);
                    if (checking)
                    {
                        var checkBox = new CheckBox
                        {
                            Size = new Size(251, 29),
                            Location = new Point(27, 71),
                            Text = item.Name,
                            Checked = true
                        };
                        flpn.Controls.Add(checkBox);
                        checkBox.CheckedChanged += UnCheckedValue;
                    }
                    else
                    {
                        var checkBox = new CheckBox
                        {
                            Size = new Size(251, 29),
                            Location = new Point(27, 71),
                            Text = item.Name,
                            Checked = false
                        };
                        flpn.Controls.Add(checkBox);
                        checkBox.CheckedChanged += CheckedValue;
                    }
                }
            }

            groupBox.Controls.Add(flpn);
            return groupBox;            
        }

        private void CheckedValue(object sender, EventArgs e)
        {
            var get = (CheckBox) sender;
            var getValue = get.Text;
            var input = new TempManagement{WorkerId = _workerId,Forms = "Medical's Form",Services = "Consultation",Categorys = getValue};
            _db.TempManagements.Add(input);
            _db.SaveChanges();

            Management.MedicalPanel();
        }

        private void UnCheckedValue(object sender, EventArgs e)
        {
            var check = (CheckBox)sender;
            var getCategoryName = check.Text;

            var delete = _db.TempManagements.Single(v => v.Categorys == getCategoryName);
            _db.TempManagements.Remove(delete);
            _db.SaveChanges();

            Management.MedicalPanel();
        }
    }
}
