using System.Data.Entity.Migrations;
using System.Linq;
using Hospital_Entity_Framework;

namespace PatientManagement.Class
{
  public   class DefaultSamplePrint
    {
        private readonly HospitalDbContext _db = new HospitalDbContext();
       
        public void InsertOrUpdate(int workerid,int samplenumber,int paddingtop,int paddingleft,int paddingright,int paddingdown)
        {
            var checkworkerandsamplenumber = _db.DefaultSamples.Any(v => v.WorkerId == workerid && v.SampleNumber==samplenumber);
            if (checkworkerandsamplenumber==false)
            {
                var insert = new DefaultSample()
                {
                    WorkerId = workerid,
                    SampleNumber = samplenumber,
                    PaddingTop = paddingtop,
                    PadddingLeft = paddingleft,
                    PaddingRight = paddingright,
                    PaddingDown = paddingdown,
                    Using = "True",
                };
                _db.DefaultSamples.Add(insert);
                _db.SaveChanges();
               
            }
            else
            {
                var update = _db.DefaultSamples.Single(v => v.WorkerId == workerid && v.SampleNumber == samplenumber);
                update.PaddingTop = paddingtop;
                update.PadddingLeft = paddingleft;
                update.PaddingRight = paddingright;
                update.PaddingDown = paddingdown;
                update.Using = "True";
                _db.DefaultSamples.AddOrUpdate(update);
                _db.SaveChanges();
            }
            
        }

        public int SearchId(int workerid)
        {
            var checkdefaultsample = _db.DefaultSamples.Any( v => v.WorkerId  == workerid && v.Using=="True");
            if (checkdefaultsample)
            {
                var getdefaultsample = _db.DefaultSamples.Single(v => v.WorkerId == workerid && v.Using=="True");
                return getdefaultsample.SampleNumber;
            }
                return 1;
        }

        public bool SearchWorkerId(int workerid)
        {
            var getworkerid = _db.DefaultSamples.Any(v => v.WorkerId == workerid);
            return getworkerid;
        }

        public void SetUsing(int workerid, int samplenumber, bool sampleusing)
        {
            var checksetusing = _db.DefaultSamples.Any(v => v.WorkerId == workerid && v.SampleNumber == samplenumber);
            if (checksetusing)
            {
                var setusing = _db.DefaultSamples.Single(v => v.WorkerId == workerid && v.SampleNumber == samplenumber);
                setusing.Using = sampleusing.ToString();
                _db.DefaultSamples.AddOrUpdate(setusing);
                _db.SaveChanges();
            }   
        }

        public DefaultSample SetPadding(int workerid,int samplenumber)
        {
            var getdefaultsamplepadding = _db.DefaultSamples.Single(v => v.WorkerId == workerid && v.SampleNumber == samplenumber && v.Using == "True");
            return getdefaultsamplepadding;
        }

        public bool CheckSampleNumber(int workerid,int samplenumber)
        {
            var checkdefaultsample = _db.DefaultSamples.Any(v => v.WorkerId == workerid && v.SampleNumber  == samplenumber);
            return checkdefaultsample;
        }
        public DefaultSample ShowPadding(int workerid, int samplenumber)
        {
            var getsamplepadding = _db.DefaultSamples.Single(v => v.WorkerId == workerid && v.SampleNumber == samplenumber);
            return getsamplepadding;
        }
    }
}
