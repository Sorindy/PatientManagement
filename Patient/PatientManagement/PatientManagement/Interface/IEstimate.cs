﻿using System;

/*using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;*/

namespace PatientManagement.Interface
{
    public interface IEstimate
    {
        void Insert(int patientid, int categoryid, int workerid, int? nurseid, int? referrerid, DateTime date, string description);
        void Update(int id, int categoryid, int workerid, int? nurseid, int? referrerid, DateTime date, string description);
        void Delete(int id);
        object Show();
    }
}
