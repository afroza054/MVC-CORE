using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Project_Work_2.Models;

namespace Project_Work_2.BILL
{
    public class OnlineSiteRepo : IOnlineRepo
    {
        JobDbContext db;
        public OnlineSiteRepo(JobDbContext db)
        {
            this.db = db;
        }
       public OnlineJobSite Get(int id)
        {
            return db.OnlineJobSites.FirstOrDefault(x => x.OnlineJobSiteId == id);
        }

        public List<OnlineJobSite> GetAll()
        {
            return db.OnlineJobSites.ToList();
        }

        public List<OnlineJobSite> GetWithChildred()
        {
            return db.OnlineJobSites
                 .Include(x => x.JobAdvertisements)
                 .ThenInclude(y => y.JobApplicants)
                 .ToList();
        }

        public bool Insert(OnlineJobSite oj)
        {
            db.OnlineJobSites.Add(oj);
            return db.SaveChanges() > 0;
        }

        public bool Update(OnlineJobSite oj, bool childIncluded = false)
        {
            // db.Entry(trade).State = EntityState.Modified;
            var orignal = db.OnlineJobSites.Include(x => x.JobAdvertisements).First(x => x.OnlineJobSiteId == oj.OnlineJobSiteId);
            orignal.OnlineJobSiteName = oj.OnlineJobSiteName;
            orignal.StartedJourney = oj.StartedJourney;
            orignal.Web = oj.Web;
            
            if (oj.JobAdvertisements != null && oj.JobAdvertisements.Count > 0)
            {
                var courses = oj.JobAdvertisements.ToArray();
                for (var i = 0; i < courses.Length; i++)
                {
                    var temp = orignal.JobAdvertisements.FirstOrDefault(c => c.JobAdvertisementId == courses[i].JobAdvertisementId);
                    if (temp != null)
                    {
                        temp.JobTypeName = courses[i].JobTypeName;
                        temp.Responsibility = courses[i].Responsibility;

                    }
                    else
                    {
                        orignal.JobAdvertisements.Add(courses[i]);
                    }
                }
                foreach (var c in orignal.JobAdvertisements)
                {
                    var temp = oj.JobAdvertisements.FirstOrDefault(t => t.JobAdvertisementId == c.JobAdvertisementId);
                    if (temp == null)
                        db.Entry(c).State = EntityState.Deleted;
                }
            }

            return db.SaveChanges() > 0;
        }
        public bool Delete(int id)
        {
            db.Entry(new OnlineJobSite { OnlineJobSiteId = id }).State = EntityState.Deleted;
            return db.SaveChanges() > 0;
        }
    }
}
