using System;
using System.Collections.Generic;
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
        private readonly HospitalDbContext _db = new HospitalDbContext();
        private BindingSource _bs=new BindingSource(); 
        private int _workerId;
        public Management Management;

        public void Insert(string name)
        {
            var insert = new Hospital_Entity_Framework.LaboratoryCategory()
            {
                Name = name,
            };
            _db.LaboratoryCategories.Add(insert);
            _db.SaveChanges();
        }

        public void Update(int id, string name)
        {
            var update = _db.LaboratoryCategories.Single(v => v.Id == id);
            update.Name = name;
            _db.LaboratoryCategories.AddOrUpdate(update);
            _db.SaveChanges();
        }

        public void Delete(int id)
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
                    v.Name
                };
            _bs.DataSource = getcategory.ToList();
            return _bs;
        }

        public Dictionary<int, string> ShowCategoryName()
        {
            var getcategory = _db.LaboratoryCategories;
            var dic = new Dictionary<int, string>();
            foreach (var item in getcategory)
            {
                dic.Add(item.Id, item.Name);
            }
            return dic;
        }

        public int SearchId(int categoryId)
        {
            var getcategory = _db.LaboratoryCategories.Single(v => v.Id == categoryId);
            return getcategory.Id;
        }

        public Dictionary<int, string> ShowCategoryForDoctor(int workerId)
        {
            var getcategory = _db.Managements.First(v => v.Account.WorkerId == workerId).LaboratoryCategories;
            var dic = new Dictionary<int, string>();
            foreach (var item in getcategory)
            {
                dic.Add(item.Id, item.Name);
            }
            return dic;
        }

        public GroupBox ShowCategoryBox(int workerId)
        {
            _workerId = workerId;
            var groupBox = new GroupBox();
            var flpn = new FlowLayoutPanel
            {
                FlowDirection = FlowDirection.TopDown,
                Dock = DockStyle.Fill,
                Size = new Size(508, 65),
                Location = new Point(6, 29),
                AutoScroll = true,
            };
            groupBox.Size = new Size(520, 100);
            groupBox.Location = new Point(3, 3);
            groupBox.Text = @"Laboratory";
            var getCategroy = from v in _db.LaboratoryCategories select new { v.Name };
            foreach (var item in getCategroy)
            {
                var singleOrDefault = _db.Managements.SingleOrDefault(v => v.Account.WorkerId == workerId);
                var checkCategory = singleOrDefault != null && singleOrDefault.LaboratoryCategories
                                        .Any(v => v.Name == item.Name);

                if (checkCategory)
                {
                    var insert = new TempManagement { WorkerId = _workerId, Forms = "Medical's Form", Services = "Laboratory", Categorys = item.Name };
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
            var get = (CheckBox)sender;
            var getValue = get.Text;
            var input = new TempManagement { WorkerId = _workerId, Forms = "Medical's Form", Services = "Laboratory", Categorys = getValue };
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
