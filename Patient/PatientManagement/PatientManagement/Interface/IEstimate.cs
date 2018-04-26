using System;

namespace PatientManagement.Interface
{
    public interface IEstimate
    {
        void Insert(int? visitid,int? visitcount,int patientid, int categoryid, int workerid, int? nurseid, int? referrerid, DateTime date, string description);
        void Update(int id, int categoryid, int workerid, int? nurseid, int? referrerid, DateTime date, string description);
        object Show();
        string GetPath(int estimateId);
        string GetRefferrerId(int estimateId);
        string GetNurseId(int estimateId);

    }
}
