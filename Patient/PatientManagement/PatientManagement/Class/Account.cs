using System;
using System.Data.Entity.Migrations;
using System.Linq;
using Hospital_Entity_Framework;

namespace PatientManagement.Class
{
    public class Account
    {

        private HospitalDbContext _db=new HospitalDbContext();

        public void Insert(string id,string workerId, string username, string password)
        {
            var insert=new Hospital_Entity_Framework.Account(){Id = id,WorkerId =workerId,UserName = username,Password = password};

            _db.Accounts.Add(insert);
            _db.SaveChanges();
        }

        public void Delete(string id)
        {
            var delete = _db.Accounts.Single(v => v.Id == id);

            _db.Accounts.Remove(delete);
            _db.SaveChanges();
        }

        public void Update(string id, string username, string password)
        {
            var update = _db.Accounts.Single(v => v.Id == id);
            update.UserName = username;
            update.Password = password;

            _db.Accounts.AddOrUpdate(update);
            _db.SaveChanges();
        }

        public Hospital_Entity_Framework.Account Selection(Hospital_Entity_Framework.Worker worker)
        {
            var selection = from v in _db.Accounts
                where v.WorkerId == worker.Id
                select new
                {
                    v.Id,
                    v.WorkerId,
                    v.UserName,
                    v.Password
                };
            foreach (var item in selection)
            {
                var account=new Hospital_Entity_Framework.Account(){Id = item.Id,WorkerId = item.WorkerId,UserName = item.UserName,Password = item.Password};
                return account;
            }
            return null;
        }

        public int CheckAccount(int id)
        {
            int s;
            try
            {
                var check = _db.Accounts.Single(v => v.WorkerId == id);
                s = check.WorkerId;
            }
            catch
            {
                s = 0;
            }
            return s;
        }

    }
}
