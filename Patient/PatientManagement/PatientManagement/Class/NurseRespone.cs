using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hospital_Entity_Framework;

namespace PatientManagement.Class
{
   public class NurseRespone
   {
       private readonly HospitalDbContext _db = new HospitalDbContext();
       private readonly BindingSource _bs = new BindingSource();

       public void ThreadProcessing()
       {
           SelectTempWaiting();
       }

       public void Insert(int waitingid , int workerid)
       {
           var insert = new TempWaitingList() 
           {
               WaitingListId =waitingid ,
               WorkerId=workerid,
           };
           _db.TempWaitingLists.Add(insert);
           _db.SaveChanges();
       }

       public object SelectTempWaiting()
       {
           var gettemwaitinglist = from v in _db.TempWaitingLists
           select new
           {
              v.Id,
              v.WaitingListId,
              v.WorkerId,
              v.Worker.Name,
              v.WaitingList.Number,
              v.WaitingList.Status,
           };
           _bs.DataSource = gettemwaitinglist.ToList();
           return _bs;
       }

       public void UpdatePatientStatus()
       {

       }
   }
}
