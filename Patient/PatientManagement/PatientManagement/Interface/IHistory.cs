
namespace PatientManagement.Interface
{
    interface IHistory
    {
        void Update(int estimateId, int workerId, int? nurseId, int? refererId);
        object Show(int patientId,int categoryId);
        string GetPath(int estimateId);
    }
}
