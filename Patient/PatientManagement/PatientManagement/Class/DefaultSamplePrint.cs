using System.Data.Entity.Migrations;
using System.Linq;
using Hospital_Entity_Framework;

namespace PatientManagement.Class
{
    class DefaultSamplePrint
    {
        private readonly HospitalDbContext _db = new HospitalDbContext();
       
        public void Insert(int workerid,int printdefault)
        {
            var insert = new DefaultSample() 
            {
                WorkerId  = workerid ,
                DefaultSample1 = printdefault
            };
            _db.DefaultSamples.Add(insert);
            _db.SaveChanges();
        }

        public void Update(int workerid,int printdefault)
        {
            var update = _db.DefaultSamples.Single(v => v.WorkerId == workerid );
            update.DefaultSample1  = printdefault;
            _db.DefaultSamples.AddOrUpdate(update);
            _db.SaveChanges();
        }

        public int SearchId(int workerid)
        {
            var checkdefaultsample = _db.DefaultSamples.Any( v => v.WorkerId  == workerid );
            if (checkdefaultsample)
            {
                var getdefaultsample = _db.DefaultSamples.Single(v => v.WorkerId == workerid);
                return getdefaultsample.DefaultSample1;
            }
            else
            {
                return 1;
            }
        }

        public bool SearchWorkerId(int workerid)
        {
            var getworkerid = _db.DefaultSamples.Any(v => v.WorkerId == workerid);
            return getworkerid;
        }
    }
}
