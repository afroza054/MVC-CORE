using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Project_Work_2.Models;

namespace Project_Work_2.Repo
{
    public class OnlineJobSiteRepo : IOnlineJobSite
    {
        JobDbContext db = null;
        public OnlineJobSiteRepo(JobDbContext db) { this.db = db; }
        public void Delete(int id)
        {
            db.Entry(new OnlineJobSite{ OnlineJobSiteId = id }).State = EntityState.Deleted;
            db.SaveChanges();
        }

        public void Edit(OnlineJobSite o)
        {
            db.Entry(o).State = EntityState.Modified;
            db.SaveChanges();
        }

        public List<OnlineJobSite> GetAll()
        {
            return db.OnlineJobSites.ToList();
        }

        public OnlineJobSite GetOnlineJobSiteById(int id)
        {
            return db.OnlineJobSites.FirstOrDefault(x => x.OnlineJobSiteId == id);
        }

        public void Insert(OnlineJobSite o)
        {
            db.OnlineJobSites.Add(o);
            db.SaveChanges();
        }
    }
}
