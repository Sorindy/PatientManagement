﻿using System.Linq;
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
              v.Worker.LastName,
              v.WaitingList.Number,
              v.WaitingList.Status,
           };
           _bs.DataSource = gettemwaitinglist.ToList();
           return _bs;
       }

       public void DeleteTempWaitingList(int tempwaitingid)
       {
           var delete = _db.TempWaitingLists.Single(v => v.Id == tempwaitingid);
           _db.TempWaitingLists.Remove(delete);
           _db.SaveChanges();
       }

       public void DeleteTempWaitingListByWaitingId(int waitingid)
       {
           var delete = _db.TempWaitingLists.Single(v => v.WaitingListId == waitingid);
           _db.TempWaitingLists.Remove(delete);
           _db.SaveChanges();
       }
   }
}
