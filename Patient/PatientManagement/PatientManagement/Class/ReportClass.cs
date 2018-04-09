using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Hospital_Entity_Framework;

namespace PatientManagement.Class
{
    public class ReportClass
    {

        private readonly HospitalDbContext _db=new HospitalDbContext();

        public BindingSource ShowAll(DateTime startDate, DateTime endDate)
        {
            var lists = GetList(startDate, endDate);
            var getAll = lists.OrderBy(v => v.Date).ThenBy(v => v.Service).ThenBy(v => v.Category)
                .ThenBy(v => v.Patient).ThenBy(v => v.Doctor)
                .ThenBy(v => v.Nurse).ThenBy(v => v.Refferrer);

            var bs = new BindingSource {DataSource = getAll.ToList()};
            return bs;
        }

        public BindingSource Searching(DateTime startDate, DateTime endDate,string service,string category,string doctor,string nurse,string reffer,string patient )
        {
            var lists = GetList(startDate, endDate);

            if (service != "")
            {
                lists = lists.Where(v => v.Service == service);
            }
            if (category!="")
            {
                lists = lists.Where(v => v.Category == category);
            }
            if (doctor != "")
            {
                lists = lists.Where(v => v.Doctor == doctor);
            }
            if (nurse != "")
            {
                lists = lists.Where(v => v.Nurse == nurse);
            }
            if (reffer != "")
            {
                lists = lists.Where(v => v.Refferrer == reffer);
            }
            if (patient != "")
            {
                lists = lists.Where(v => v.Patient == patient);
            }

            var getAll = lists.OrderBy(v => v.Date).ThenBy(v => v.Service).ThenBy(v => v.Category)
                .ThenBy(v => v.Patient).ThenBy(v => v.Doctor)
                .ThenBy(v => v.Nurse).ThenBy(v => v.Refferrer);

            var bs = new BindingSource { DataSource = getAll.ToList() };
            return bs;
        }

        private IEnumerable<ListReport> GetList(DateTime startDate, DateTime endDate)
        {
            var lists = new List<ListReport>();
            var get = _db.Patients;
            foreach (var item in get)
            {
                var getCon = from c in item.ConsultationEstimates
                    where c.Date >= startDate && c.Date <= endDate
                    select c;
                foreach (var con in getCon.ToList())
                {
                    string refferrer;
                    if (con.Referrer == null) refferrer = @"NULL";
                    else
                    {
                        refferrer = con.Referrer.FirstName + @" " + con.Referrer.LastName;
                    }
                    string nurse;
                    if (con.Worker1 == null) nurse = @"NULL";
                    else
                    {
                        nurse = con.Worker1.FirstName + @" " + con.Worker1.LastName;
                    }
                    lists.Add(new ListReport(con.Date, @"Consultation"
                        , con.ConsultationCategory.Name
                        , con.Patient.FirstName + " " + con.Patient.LastName
                        , con.Worker.FirstName + @" " + con.Worker.LastName
                        , nurse
                        , refferrer));
                }
                var getLab = from c in item.LaboratoryEstimates
                    where c.Date >= startDate && c.Date <= endDate
                    select c;
                foreach (var lab in getLab.ToList())
                {
                    string refferrer;
                    if (lab.Referrer == null) refferrer = @"NULL";
                    else
                    {
                        refferrer = lab.Referrer.FirstName + @" " + lab.Referrer.LastName;
                    }
                    string nurse;
                    if (lab.Worker1 == null) nurse = @"NULL";
                    else
                    {
                        nurse = lab.Worker1.FirstName + @" " + lab.Worker1.LastName;
                    }
                    lists.Add(new ListReport(lab.Date, @"Laboratory"
                        , lab.LaboratoryCategory.Name
                        , lab.Patient.FirstName + " " + lab.Patient.LastName
                        , lab.Worker.FirstName + @" " + lab.Worker.LastName
                        , nurse
                        , refferrer));
                }
                var getMed = from c in item.MedicalImagingEstimates
                    where c.Date >= startDate && c.Date <= endDate
                    select c;
                foreach (var med in getMed.ToList())
                {
                    string refferrer;
                    if (med.Referrer == null) refferrer = @"NULL";
                    else
                    {
                        refferrer = med.Referrer.FirstName + @" " + med.Referrer.LastName;
                    }
                    string nurse;
                    if (med.Worker1 == null) nurse = @"NULL";
                    else
                    {
                        nurse = med.Worker1.FirstName + @" " + med.Worker1.LastName;
                    }
                    lists.Add(new ListReport(med.Date, @"Medical Imaging"
                        , med.MedicalImagingCategory.Name
                        , med.Patient.FirstName + " " + med.Patient.LastName
                        , med.Worker.FirstName + @" " + med.Worker.LastName
                        , nurse
                        , refferrer));
                }
                var getPre = from c in item.PrescriptionEstimates
                    where c.Date >= startDate && c.Date <= endDate
                    select c;
                foreach (var pre in getPre.ToList())
                {
                    string refferrer;
                    if (pre.Referrer == null) refferrer = @"NULL";
                    else
                    {
                        refferrer = pre.Referrer.FirstName + @" " + pre.Referrer.LastName;
                    }
                    string nurse;
                    if (pre.Worker1 == null) nurse = @"NULL";
                    else
                    {
                        nurse = pre.Worker1.FirstName + @" " + pre.Worker1.LastName;
                    }
                    lists.Add(new ListReport(pre.Date, @"Prescription"
                        , pre.PrescriptionCategory.Name
                        , pre.Patient.FirstName + " " + pre.Patient.LastName
                        , pre.Worker.FirstName + @" " + pre.Worker.LastName
                        , nurse
                        , refferrer));
                }
                var getVar = from c in item.VariousDocumentEstimates
                    where c.Date >= startDate && c.Date <= endDate
                    select c;
                foreach (var various in getVar.ToList())
                {
                    string refferrer;
                    if (various.Referrer == null) refferrer = @"NULL";
                    else
                    {
                        refferrer = various.Referrer.FirstName + @" " + various.Referrer.LastName;
                    }
                    string nurse;
                    if (various.Worker1 == null) nurse = @"NULL";
                    else
                    {
                        nurse = various.Worker1.FirstName + @" " + various.Worker1.LastName;
                    }
                    lists.Add(new ListReport(various.Date, @"Various Document"
                        , various.VariousDocumentCategory.Name
                        , various.Patient.FirstName + " " + various.Patient.LastName
                        , various.Worker.FirstName + @" " + various.Worker.LastName
                        , nurse
                        , refferrer));
                }
            }
            return lists;
        }

        public Dictionary<int, string> ListsDoctor()
        {
            var get = _db.Workers.Where(v => v.Position == "Doctor");
            return get.ToList().ToDictionary(item => item.Id, item => item.FirstName + " " + item.LastName);
        }

        public Dictionary<int, string> ListNurse()
        {
            var get = _db.Workers.Where(v => v.Position == "Nurse");
            return get.ToList().ToDictionary(item => item.Id, item => item.FirstName + " " + item.LastName);
        }

        public Dictionary<int, string> ListRefferrer()
        {
            var get = _db.Referrers;
            return get.ToList().ToDictionary(item => item.Id, item => item.FirstName + " " + item.LastName);
        }

        public Dictionary<int, string> ListPatient()
        {
            var get = _db.Patients;
            return get.ToList().ToDictionary(item => item.Id, item => item.FirstName + " " + item.LastName);
        }
    }

    public class ListReport
    {
        public DateTime Date { get; set; }
        public string Service { get; set; }
        public string Category { get; set; }
        public string Patient { get; set; }
        public string Doctor { get; set; }
        public string Nurse { get; set; }
        public string Refferrer { get; set; }

        public ListReport(DateTime date, string service, string category, string patient, string doctor, string nurse,
            string refferrer)
        {
            Date = date;
            Service = service;
            Category = category;
            Patient = patient;
            Doctor = doctor;
            Nurse = nurse;
            Refferrer = refferrer;
        }
    }
}
