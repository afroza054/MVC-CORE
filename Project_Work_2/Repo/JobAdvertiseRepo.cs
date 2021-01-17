using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Project_Work_2.Models;

namespace Project_Work_2.Repo
{
    public class JobAdvertiseRepo : IJobAdvertisement
    {
        JobDbContext db = null;
        public JobAdvertiseRepo(JobDbContext db) { this.db = db; }
        public void Delete(int id)
        {
            db.Entry(new JobAdvertisement {JobAdvertisementId = id }).State = EntityState.Deleted;
            db.SaveChanges();
        }

        public void Edit(JobAdvertisement a)
        {
            db.Entry(a).State = EntityState.Modified;
            db.SaveChanges();
        }

        public List<JobAdvertisement> GetAll()
        {
            return db.JobAdvertisements.Include(x => x.OnlineJobSite).ToList();
        }

        public JobAdvertisement GetJobAdvertisementById(int id)
        {
            return db.JobAdvertisements.Include(x => x.OnlineJobSite).ToList().FirstOrDefault(x => x.JobAdvertisementId == id);
        }

        public List<OnlineJobSite> GetJobSite()
        {
            return db.OnlineJobSites.ToList();
        }

        public void Insert(JobAdvertisement a)
        {
            db.JobAdvertisements.Add(a);
            db.SaveChanges();
        }
    }
}
