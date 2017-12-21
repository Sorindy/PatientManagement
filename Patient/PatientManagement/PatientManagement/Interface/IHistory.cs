
using System.Collections.Generic;

namespace PatientManagement.Interface
{
    interface IHistory
    {
        void Insert(int estimateId, int workerId, string description);
        object Show();
        object ShowHistory(int estimateId);
    }
}
