﻿using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Windows.Forms;
using Hospital_Entity_Framework;
using PatientManagement.Interface;

namespace PatientManagement.Class
{
   public  class PrescriptionCategory: ICategory 
    {
        private readonly HospitalDbContext _db = new HospitalDbContext();
        private readonly BindingSource _bs=new BindingSource();
       // private int _workerId=0;
        public Management Management;

        public Hospital_Entity_Framework.WaitingList CheckWaitingList(int patientId, int categoryId)
        {
            var firstOrDefault = _db.WaitingLists.FirstOrDefault(v => v.PatientId == patientId);
            var get = firstOrDefault != null && firstOrDefault.PrescriptionCategories.Any(v => v.Id == categoryId);
            if (get)
            {
                return firstOrDefault;
            }
            return null;
        }

       public void Insert(string name)
        {
            var insert = new Hospital_Entity_Framework.PrescriptionCategory()
            {
                Name = name,
                Available = true
            };
            _db.PrescriptionCategories.Add(insert);
            _db.SaveChanges();
        }

        public void Update(int id, string name)
        {
            var update = _db.PrescriptionCategories.Single(v => v.Id == id);
            update.Name = name;
            _db.PrescriptionCategories.AddOrUpdate(update);
            _db.SaveChanges();
        }

        public void Delete(int id)
        {
            var delete = _db.PrescriptionCategories.Single(vid => vid.Id == id);
            delete.Available = false;
            _db.PrescriptionCategories.AddOrUpdate(delete);
            _db.SaveChanges();
        }

        public object Show()
        {
            var getcategory = from v in _db.PrescriptionCategories.Where(v => v.Available)
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
            var getcategory = _db.PrescriptionCategories.Where(v => v.Available);
            var dic = new Dictionary<int, string>();
            foreach (var item in getcategory)
            {
                dic.Add(item.Id, item.Name);
            }
            return dic;
        }

        public int SearchId(int categoryId)
        {
            var getcategory = _db.PrescriptionCategories.Where(v => v.Available).Single(v => v.Id == categoryId);
            return getcategory.Id;
        }

        public Dictionary<int, string> ShowCategoryForDoctor(int workerId)
        {
            var getcategory = _db.Managements.First(v => v.Account.WorkerId == workerId).PrescriptionCategories.Where(v => v.Available);
            var dic = new Dictionary<int, string>();
            foreach (var item in getcategory)
            {
                dic.Add(item.Id, item.Name);
            }
            return dic;
        }

        public Dictionary<int, string> ShowAllCategoryForHistory()
        {
            var getCategory = _db.PrescriptionCategories;
            var dic = new Dictionary<int, string>();
            foreach (var item in getCategory)
            {
                dic.Add(item.Id, item.Name);
            }
            return dic;
        }

        //Use as check box
        //public GroupBox ShowCategoryBox(int workerId)
        //{
        //    var checkListBox = new CheckedListBox();
        //    var groupBox = new GroupBox();
        //    var flpn = new FlowLayoutPanel
        //    {
        //        FlowDirection = FlowDirection.TopDown,
        //        Dock = DockStyle.Fill,
        //        Size = new Size(508, 54),
        //        AutoScroll = true
        //    };
        //    groupBox.Size = new Size(520, 100);
        //    checkListBox.Size = new Size(508, 54);

        //    groupBox.Text = @"Presciption";
        //    var getCategroy = from v in _db.PrescriptionCategories select new { v.Name };
        //    foreach (var item in getCategroy)
        //    {
        //        var singleOrDefault = _db.Managements.SingleOrDefault(v => v.Account.WorkerId == workerId);
        //        var checkCategory = singleOrDefault != null && singleOrDefault.ConsultationCategories
        //                                .Any(v => v.Name == item.Name);

        //        if (checkCategory)
        //        {
        //            var insert = new TempManagement { WorkerId = _workerId, Forms = "Medical's Form", Services = "Prescription", Categorys = item.Name };
        //            _db.TempManagements.Add(insert);
        //            _db.SaveChanges();
        //            var checking = _db.TempManagements.Any(v => v.Categorys == item.Name);
        //            if (checking)
        //            {
        //                var checkBox = new CheckBox
        //                {
        //                    Size = new Size(251, 29),
        //                    Location = new Point(27, 71),
        //                    Text = item.Name,
        //                    Checked = true
        //                };
        //                flpn.Controls.Add(checkBox);
        //                checkBox.CheckedChanged += UnCheckedValue;
        //            }
        //            else
        //            {
        //                var checkBox = new CheckBox
        //                {
        //                    Size = new Size(251, 29),
        //                    Location = new Point(27, 71),
        //                    Text = item.Name,
        //                    Checked = false
        //                };
        //                flpn.Controls.Add(checkBox);
        //                checkBox.CheckedChanged += CheckedValue;
        //            }
        //        }
        //        else
        //        {
        //            var checking = _db.TempManagements.Any(v => v.Categorys == item.Name);
        //            if (checking)
        //            {
        //                var checkBox = new CheckBox
        //                {
        //                    Size = new Size(251, 29),
        //                    Location = new Point(27, 71),
        //                    Text = item.Name,
        //                    Checked = true
        //                };
        //                flpn.Controls.Add(checkBox);
        //                checkBox.CheckedChanged += UnCheckedValue;
        //            }
        //            else
        //            {
        //                var checkBox = new CheckBox
        //                {
        //                    Size = new Size(251, 29),
        //                    Location = new Point(27, 71),
        //                    Text = item.Name,
        //                    Checked = false
        //                };
        //                flpn.Controls.Add(checkBox);
        //                checkBox.CheckedChanged += CheckedValue;
        //            }
        //        }
        //    }

        //    groupBox.Controls.Add(flpn);
        //    return groupBox;
        //}

        //private void CheckedValue(object sender, EventArgs e)
        //{
        //    var get = (CheckBox)sender;
        //    var getValue = get.Text;
        //    var input = new TempManagement { WorkerId = _workerId, Forms = "Medical's Form", Services = "Prescription", Categorys = getValue };
        //    _db.TempManagements.Add(input);
        //    _db.SaveChanges();

        //    Management.MedicalPanel();
        //}

        //private void UnCheckedValue(object sender, EventArgs e)
        //{
        //    var check = (CheckBox)sender;
        //    var getCategoryName = check.Text;

        //    var delete = _db.TempManagements.Single(v => v.Categorys == getCategoryName);
        //    _db.TempManagements.Remove(delete);
        //    _db.SaveChanges();

        //    Management.MedicalPanel();
        //}
    }
}
