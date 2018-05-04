using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Hospital_Entity_Framework;
using Button = System.Windows.Forms.Button;

namespace PatientManagement.Class
{
    public class Login
    {
        private readonly HospitalDbContext _db=new HospitalDbContext();
        private Hospital_Entity_Framework.Account _account;

        public Hospital_Entity_Framework.Account LoginAccount(string username, string password)
        {
            var check = _db.Accounts.SingleOrDefault(v => v.UserName == username && v.Password == password && v.Worker.Hire);
            CheckDateAndDeleteAllWaitingList();
            return check;
        }

        public FlowLayoutPanel ButtonToForm(Hospital_Entity_Framework.Account account)
        {
            var flpn=new FlowLayoutPanel()
            {
                FlowDirection = FlowDirection.TopDown,
                Dock = DockStyle.Fill,
                Name = @"flpnButtonForm",
                AutoScroll = true,
                WrapContents = false
            };
            _account = account;
            var firstOrDefault = _db.Managements.FirstOrDefault(v => v.AccountId == account.Id);
            if (firstOrDefault != null)
            {
                var checkForm = firstOrDefault.Forms;

                foreach (var form in checkForm)
                {
                    var color = ColorTranslator.FromHtml("#3399FF");
                    var btn=new Button
                    {
                        Font=new Font("Nova Cut",12),
                        Text = form.Name.Remove(form.Name.Length-7),
                        Height = 50,
                        Width = flpn.Width,
                        BackColor = Color.FromArgb(128,color)
                    };

                    btn.MouseHover += MouseHover;
                    btn.MouseLeave += MouseLeave;
                    btn.Click += OpenForm;

                    flpn.Controls.Add(btn);
                }
            }
            return flpn;
        }

        private void MouseHover(object sender, EventArgs e)
        {
            var btn = (Button) sender;
            btn.BackColor=Color.Green;
        }

        private void MouseLeave(object sender, EventArgs e)
        {
            var btn = (Button) sender;
            var color = ColorTranslator.FromHtml("#3399FF");
            btn.BackColor = Color.FromArgb(128,color);
        }

        private void OpenForm(object sender,EventArgs e)
        {
            var btn = (Button) sender;
            var text = btn.Text;

            CatelogForm form = null;
            if(Application.OpenForms.OfType<CatelogForm>().Count()!=0)
            form = Application.OpenForms.OfType<CatelogForm>().LastOrDefault();
            if (form != null)
            {
                var gbo = form.pnlFill;
                form.Skip = true;
                gbo.Controls.Clear();

                if (text == "Worker")
                {
                    if (Application.OpenForms.OfType<HistorysForm>().Count() != 0)
                    {
                        var firstOrDefault = Application.OpenForms.OfType<HistorysForm>().LastOrDefault();
                        if (firstOrDefault != null)
                        {
                            if (firstOrDefault.NewMedical||firstOrDefault.Editing)
                            {
                                var result = MessageBox.Show(@"Do you really want to leave this? leaving this document will delete all your current work.", @"Leave", MessageBoxButtons.YesNo);
                                if (result == DialogResult.No)
                                {
                                    gbo.Controls.Add(firstOrDefault);
                                    firstOrDefault.CatelogForm.Skip = false;
                                    firstOrDefault.Show();
                                    return;
                                }
                                if (result == DialogResult.Yes)
                                {
                                    firstOrDefault.Close();
                                }
                            }
                        }
                    }
                    if (Application.OpenForms.OfType<WorkerListForm>().Count() == 1)
                    {
                        var firstOrDefault = Application.OpenForms.OfType<WorkerListForm>().FirstOrDefault();
                        if (firstOrDefault != null)
                        {
                           firstOrDefault.Close();
                           var selectionForm = new WorkerListForm()
                            {
                                TopLevel = false,
                                Dock = DockStyle.Fill,
                                AutoScroll = true,
                                CatelogForm = form
                            };
                           gbo.Controls.Add(selectionForm);
                           selectionForm.Show();
                        }
                    }
                    //if (Application.OpenForms.OfType<MedicalsForm>().Count() == 1)
                    //{
                    //    var firstOrDefault = Application.OpenForms.OfType<MedicalsForm>().FirstOrDefault();
                    //    if (firstOrDefault != null)
                    //    {
                    //        firstOrDefault.Clear();
                    //        firstOrDefault.Close();
                    //    }                           
                    //}
                    else
                    {
                        var selectionForm = new WorkerListForm()
                        {
                            TopLevel = false,
                            Dock = DockStyle.Fill,
                            AutoScroll = true,
                            CatelogForm = form
                        };
                        gbo.Controls.Add(selectionForm);
                        selectionForm.Show();
                    }
                }
                if (text == "Category")
                {
                    if (Application.OpenForms.OfType<HistorysForm>().Count() != 0)
                    {
                        var firstOrDefault = Application.OpenForms.OfType<HistorysForm>().LastOrDefault();
                        if (firstOrDefault != null)
                        {
                            if (firstOrDefault.NewMedical || firstOrDefault.Editing)
                            {
                                var result = MessageBox.Show(@"Do you really want to leave this? leaving this document will delete all your current work.", @"Leave", MessageBoxButtons.YesNo);
                                if (result == DialogResult.No)
                                {
                                    gbo.Controls.Add(firstOrDefault);
                                    firstOrDefault.CatelogForm.Skip = false;
                                    firstOrDefault.Show();
                                    return;
                                }
                                if (result == DialogResult.Yes)
                                {
                                    firstOrDefault.Close();
                                }
                            }
                        }
                    }
                    if (Application.OpenForms.OfType<Category>().Count() == 1)
                    {
                        var firstOrDefault = Application.OpenForms.OfType<Category>().FirstOrDefault();
                        if (firstOrDefault != null)firstOrDefault.Close();
                        var selectionForm = new Category()
                        {
                            TopLevel = false,
                            Dock = DockStyle.Fill,
                            AutoScroll = true
                        };
                        gbo.Controls.Add(selectionForm);
                        selectionForm.Show();   
                    }
                    //if (Application.OpenForms.OfType<MedicalsForm>().Count() == 1)
                    //{
                    //    var firstOrDefault = Application.OpenForms.OfType<MedicalsForm>().FirstOrDefault();
                    //    if (firstOrDefault != null)
                    //    {
                    //        firstOrDefault.Clear();
                    //        firstOrDefault.Close();
                    //    }
                    //}
                    else
                    {
                        var selectionForm = new Category()
                        {
                            TopLevel = false,
                            Dock = DockStyle.Fill,
                            AutoScroll = true
                        };
                        gbo.Controls.Add(selectionForm);
                        selectionForm.Show();
                    }
                }
                if (text == "Patient")
                {
                    if (Application.OpenForms.OfType<HistorysForm>().Count() != 0)
                    {
                        var firstOrDefault = Application.OpenForms.OfType<HistorysForm>().LastOrDefault();
                        if (firstOrDefault != null)
                        {
                            if (firstOrDefault.NewMedical || firstOrDefault.Editing)
                            {
                                var result = MessageBox.Show(@"Do you really want to leave this? leaving this document will delete all your current work.", @"Leave", MessageBoxButtons.YesNo);
                                if (result == DialogResult.No)
                                {
                                    gbo.Controls.Add(firstOrDefault);
                                    firstOrDefault.CatelogForm.Skip = false;
                                    firstOrDefault.Show();
                                    return;
                                } 
                                if (result == DialogResult.Yes)
                                {
                                    firstOrDefault.Close();
                                }
                            }
                        }
                    }
                    if (Application.OpenForms.OfType<PatientListForm>().Count() == 1)
                    {
                        var firstOrDefault = Application.OpenForms.OfType<PatientListForm>().FirstOrDefault();
                        if (firstOrDefault != null)
                        {
                            firstOrDefault.Close();
                            var selectionForm = new PatientListForm()
                            {
                                TopLevel = false,
                                Dock = DockStyle.Fill,
                                AutoScroll = true,
                                Account = _account,
                                CatelogForm = form
                            };
                            gbo.Controls.Add(selectionForm);
                            selectionForm.Show();
                        }
                    } 
                    //if (Application.OpenForms.OfType<MedicalsForm>().Count() == 1)
                    //{
                    //    var firstOrDefault = Application.OpenForms.OfType<MedicalsForm>().FirstOrDefault();
                    //    if (firstOrDefault != null)
                    //    {
                    //        firstOrDefault.Clear();
                    //        firstOrDefault.Close();
                    //    }
                    //}

                    else
                    {
                        var selectionForm = new PatientListForm()
                        {
                            TopLevel = false,
                            Dock = DockStyle.Fill,
                            AutoScroll = true,
                            Account = _account,
                            CatelogForm = form
                        };
                        gbo.Controls.Add(selectionForm);
                        selectionForm.Show();
                    }
                }
                if (text == "CheckIn")
                {
                    if (Application.OpenForms.OfType<HistorysForm>().Count() != 0)
                    {
                        var firstOrDefault = Application.OpenForms.OfType<HistorysForm>().LastOrDefault();
                        if (firstOrDefault != null)
                        {
                            if (firstOrDefault.NewMedical || firstOrDefault.Editing)
                            {
                                var result = MessageBox.Show(@"Do you really want to leave this? leaving this document will delete all your current work.", @"Leave", MessageBoxButtons.YesNo);
                                if (result == DialogResult.No)
                                {
                                    gbo.Controls.Add(firstOrDefault);
                                    firstOrDefault.CatelogForm.Skip = false;
                                    firstOrDefault.Show();
                                    return;
                                }
                                if (result == DialogResult.Yes)
                                {
                                    firstOrDefault.Close();
                                }
                            }
                        }
                    }
                    if(Application.OpenForms.OfType<CheckInsForm>().Count()==1)
                    {
                        var firstOrDefault = Application.OpenForms.OfType<CheckInsForm>().FirstOrDefault();
                        if (firstOrDefault != null)
                        {
                            firstOrDefault.Close();
                            var selectionForm = new CheckInsForm
                            {
                                TopLevel = false,
                                Dock = DockStyle.Fill,
                                AutoScroll = true
                            };
                            gbo.Controls.Add(selectionForm);
                            selectionForm.Show();
                        }                           
                    }
                    //if (Application.OpenForms.OfType<MedicalsForm>().Count() == 1)
                    //{
                    //    var firstOrDefault = Application.OpenForms.OfType<MedicalsForm>().FirstOrDefault();
                    //    if (firstOrDefault != null)
                    //    {
                    //        firstOrDefault.Clear();
                    //        firstOrDefault.Close();
                    //    }
                    //}
                    else
                    {
                        var selectionForm = new CheckInsForm
                        {
                            TopLevel = false,
                            Dock = DockStyle.Fill,
                            AutoScroll = true
                        };
                        gbo.Controls.Add(selectionForm);
                        selectionForm.Show();
                    }
                }
                if (text == "Sample")
                {
                    if (Application.OpenForms.OfType<HistorysForm>().Count() != 0)
                    {
                        var firstOrDefault = Application.OpenForms.OfType<HistorysForm>().LastOrDefault();
                        if (firstOrDefault != null)
                        {
                            if (firstOrDefault.NewMedical || firstOrDefault.Editing)
                            {
                                var result = MessageBox.Show(@"Do you really want to leave this? leaving this document will delete all your current work.", @"Leave", MessageBoxButtons.YesNo);
                                if (result == DialogResult.No)
                                {
                                    gbo.Controls.Add(firstOrDefault);
                                    firstOrDefault.CatelogForm.Skip = false;
                                    firstOrDefault.Show();
                                    return;
                                }
                                if (result == DialogResult.Yes)
                                {
                                    firstOrDefault.Close();
                                }
                            }
                        }
                    }
                    if (Application.OpenForms.OfType<SamplesForm>().Count() == 1)
                    {
                        var firstOrDefault = Application.OpenForms.OfType<SamplesForm>().FirstOrDefault();
                        if (firstOrDefault != null)
                        {
                            firstOrDefault.Close();
                            var selectionForm = new SamplesForm()
                            {
                                TopLevel = false,
                                Dock = DockStyle.Fill,
                                AutoScroll = true
                            };
                            gbo.Controls.Add(selectionForm);
                            selectionForm.Show();
                        }                           
                    }
                    //if (Application.OpenForms.OfType<MedicalsForm>().Count() == 1)
                    //{
                    //    var firstOrDefault = Application.OpenForms.OfType<MedicalsForm>().FirstOrDefault();
                    //    if (firstOrDefault != null)
                    //    {
                    //        firstOrDefault.Clear();
                    //        firstOrDefault.Close();
                    //    }
                    //}
                    else
                    {
                        var selectionForm = new SamplesForm()
                        {
                            TopLevel = false,
                            Dock = DockStyle.Fill,
                            AutoScroll = true
                        };
                        gbo.Controls.Add(selectionForm);
                        selectionForm.Show();
                    }
                }
                if (text == "Management")
                {
                    if (Application.OpenForms.OfType<HistorysForm>().Count() != 0)
                    {
                        var firstOrDefault = Application.OpenForms.OfType<HistorysForm>().LastOrDefault();
                        if (firstOrDefault != null)
                        {
                            if (firstOrDefault.NewMedical || firstOrDefault.Editing)
                            {
                                var result = MessageBox.Show(@"Do you really want to leave this? leaving this document will delete all your current work.", @"Leave", MessageBoxButtons.YesNo);
                                if (result == DialogResult.No)
                                {
                                    gbo.Controls.Add(firstOrDefault);
                                    firstOrDefault.CatelogForm.Skip = false;
                                    firstOrDefault.Show();
                                    return;
                                }
                                if (result == DialogResult.Yes)
                                {
                                    firstOrDefault.Close();
                                }
                            }
                        }
                    }
                    if (Application.OpenForms.OfType<Managements>().Count() == 1)
                    {
                        var firstOrDefault = Application.OpenForms.OfType<Managements>().FirstOrDefault();
                        if (firstOrDefault != null)
                        {
                            firstOrDefault.Close();
                            var selectionForm = new Managements()
                            {
                                TopLevel = false,
                                Dock = DockStyle.Fill,
                                AutoScroll = true
                            };
                            gbo.Controls.Add(selectionForm);
                            selectionForm.Show();
                        }                           
                    }
                    //if (Application.OpenForms.OfType<MedicalsForm>().Count() == 1)
                    //{
                    //    var firstOrDefault = Application.OpenForms.OfType<MedicalsForm>().FirstOrDefault();
                    //    if (firstOrDefault != null)
                    //    {
                    //        firstOrDefault.Clear();
                    //        firstOrDefault.Close();
                    //    }
                    //}
                    else
                    {
                        var selectionForm = new Managements()
                        {
                            TopLevel = false,
                            Dock = DockStyle.Fill,
                            AutoScroll = true
                        };
                        gbo.Controls.Add(selectionForm);
                        selectionForm.Show();
                    }
                }
                if (text == "Medical")
                {
                    if (Application.OpenForms.OfType<HistorysForm>().Count() != 0)
                    {
                        var firstOrDefault = Application.OpenForms.OfType<HistorysForm>().LastOrDefault();
                        if (firstOrDefault != null)
                        {
                            if (firstOrDefault.NewMedical || firstOrDefault.Editing)
                            {
                                var result = MessageBox.Show(@"Do you really want to leave this? leaving this document will delete all your current work.", @"Leave", MessageBoxButtons.YesNo);
                                if (result == DialogResult.No)
                                {
                                    gbo.Controls.Add(firstOrDefault);
                                    firstOrDefault.CatelogForm.Skip = false;
                                    firstOrDefault.Show();
                                    return;
                                }
                                if (result == DialogResult.Yes)
                                {
                                    firstOrDefault.Close();
                                }
                            }
                        }
                    }
                    if (Application.OpenForms.OfType<MedicalsForm>().Count() == 1)
                    {
                        var firstOrDefault = Application.OpenForms.OfType<MedicalsForm>().FirstOrDefault();
                        if (firstOrDefault != null)
                        {
                            gbo.Controls.Add(firstOrDefault);
                            firstOrDefault.Show();
                        }                           
                    }
                    //if (Application.OpenForms.OfType<MedicalsForm>().Count() == 1)
                    //{
                    //    var firstOrDefault = Application.OpenForms.OfType<MedicalsForm>().FirstOrDefault();
                    //    if (firstOrDefault != null)
                    //    {
                    //        firstOrDefault.Clear();
                    //        firstOrDefault.Close();
                    //    }
                    //}
                    else
                    {
                        var selectionForm = new MedicalsForm()
                        {
                            TopLevel = false,
                            Dock = DockStyle.Fill,
                            AutoScroll = true,
                            Account = _account,
                            CatelogForm = form
                        };
                        gbo.Controls.Add(selectionForm);
                        selectionForm.Show();
                    }
                }
                if (text == "WaitingList")
                {
                    if (Application.OpenForms.OfType<HistorysForm>().Count() != 0)
                    {
                        var firstOrDefault = Application.OpenForms.OfType<HistorysForm>().LastOrDefault();
                        if (firstOrDefault != null)
                        {
                            if (firstOrDefault.NewMedical || firstOrDefault.Editing)
                            {
                                var result = MessageBox.Show(@"Do you really want to leave this? leaving this document will delete all your current work.", @"Leave", MessageBoxButtons.YesNo);
                                if (result == DialogResult.No)
                                {
                                    gbo.Controls.Add(firstOrDefault);
                                    firstOrDefault.CatelogForm.Skip = false;
                                    firstOrDefault.Show();
                                    return;
                                }
                                if (result == DialogResult.Yes)
                                {
                                    firstOrDefault.Close();
                                }
                            }
                        }
                    }
                    if (Application.OpenForms.OfType<WaitingForm>().Count() == 1)
                    {
                        var firstOrDefault = Application.OpenForms.OfType<WaitingForm>().FirstOrDefault();
                        if (firstOrDefault != null)
                        {
                            firstOrDefault.Close();
                            var selectionForm = new WaitingForm()
                            {
                                TopLevel = false,
                                Dock = DockStyle.Fill,
                                AutoScroll = true,
                                Account = _account,
                                CatelogForm = form
                            };
                            gbo.Controls.Add(selectionForm);
                            selectionForm.Show();
                        }                           
                    }
                    //if (Application.OpenForms.OfType<MedicalsForm>().Count() == 1)
                    //{
                    //    var firstOrDefault = Application.OpenForms.OfType<MedicalsForm>().FirstOrDefault();
                    //    if (firstOrDefault != null)
                    //    {
                    //        firstOrDefault.Clear();
                    //        firstOrDefault.Close();
                    //    }
                    //}
                    else
                    {
                        var selectionForm = new WaitingForm()
                        {
                            TopLevel = false,
                            Dock = DockStyle.Fill,
                            AutoScroll = true,
                            Account = _account,
                            CatelogForm = form
                        };
                        gbo.Controls.Add(selectionForm);
                        selectionForm.Show();
                    }
                }
                if (text == "Report")
                {
                    if (Application.OpenForms.OfType<HistorysForm>().Count() != 0)
                    {
                        var firstOrDefault = Application.OpenForms.OfType<HistorysForm>().LastOrDefault();
                        if (firstOrDefault != null)
                        {
                            if (firstOrDefault.NewMedical || firstOrDefault.Editing)
                            {
                                var result = MessageBox.Show(@"Do you really want to leave this? leaving this document will delete all your current work.", @"Leave", MessageBoxButtons.YesNo);
                                if (result == DialogResult.No)
                                {
                                    gbo.Controls.Add(firstOrDefault);
                                    firstOrDefault.CatelogForm.Skip = false;
                                    firstOrDefault.Show();
                                    return;
                                }
                                if (result == DialogResult.Yes)
                                {
                                    firstOrDefault.Close();
                                }
                            }
                        }
                    }
                    if (Application.OpenForms.OfType<WaitingForm>().Count() == 1)
                    {
                        var firstOrDefault = Application.OpenForms.OfType<WaitingForm>().FirstOrDefault();
                        if (firstOrDefault != null)
                        {
                            firstOrDefault.Close();
                            var selectionForm = new Report()
                            {
                                TopLevel = false,
                                Dock = DockStyle.Fill,
                                AutoScroll = true,
                            };
                            gbo.Controls.Add(selectionForm);
                            selectionForm.Show();
                        }
                    }
                    //if (Application.OpenForms.OfType<MedicalsForm>().Count() == 1)
                    //{
                    //    var firstOrDefault = Application.OpenForms.OfType<MedicalsForm>().FirstOrDefault();
                    //    if (firstOrDefault != null)
                    //    {
                    //        firstOrDefault.Clear();
                    //        firstOrDefault.Close();
                    //    }
                    //}
                    else
                    {
                        var selectionForm = new Report()
                        {
                            TopLevel = false,
                            Dock = DockStyle.Fill,
                            AutoScroll = true,
                        };
                        gbo.Controls.Add(selectionForm);
                        selectionForm.Show();
                    }
                }
            }
        }

        private void CheckDateAndDeleteAllWaitingList()
        {
            var get = _db.WaitingLists;
            if (get.Count() != 0)
            {
                if (DateTime.Today.Date > get.First().Date)
                {
                    foreach (var item in get.ToList())
                    {
                        foreach (var consultation in item.ConsultationCategories.ToList())
                        {
                            item.ConsultationCategories.Remove(consultation);
                        }
                        foreach (var laboratory in item.LaboratoryCategories.ToList())
                        {
                            item.LaboratoryCategories.Remove(laboratory);
                        }
                        foreach (var medicalImaging in item.MedicalImagingCategories.ToList())
                        {
                            item.MedicalImagingCategories.Remove(medicalImaging);
                        }
                        foreach (var prescription in item.PrescriptionCategories.ToList())
                        {
                            item.PrescriptionCategories.Remove(prescription);
                        }
                        foreach (var variousDocument in item.VariousDocumentCategories.ToList())
                        {
                            item.VariousDocumentCategories.Remove(variousDocument);
                        }
                        get.Remove(item);
                    }
                }                
            }
            _db.SaveChanges();
        }

        //public void DeleteImageFolder()
        //{
        //    string path;
        //    //var path = AppDomain.CurrentDomain.BaseDirectory;
        //    //_path = path.Remove(path.Length - 46);
        //    if (!Directory.Exists(@"S:\"))
        //    {
        //        path = @"D:\ABC soft\";
        //    }
        //    else
        //    {
        //        path = @"S:\";
        //    }
        //    try
        //    {
        //        var directory = new DirectoryInfo(path + @"RTF\images");
        //        directory.Attributes = directory.Attributes & ~FileAttributes.ReadOnly;
        //        if (directory.CreationTime < DateTime.Now.AddDays(-1))
        //        {
        //            directory.Delete(true);
        //        }
        //    }
        //    catch
        //    {
        //        //NO action
        //    }

        //}



    }
}
