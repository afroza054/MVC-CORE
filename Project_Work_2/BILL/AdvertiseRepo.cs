using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Project_Work_2.Models;

namespace Project_Work_2.BILL
{
    public class AdvertiseRepo : IAdvertise
    {
        JobDbContext db;
        public AdvertiseRepo(JobDbContext db) { this.db = db; }
        public List<JobAdvertisement> Get()
        {
            return db.JobAdvertisements.ToList();
        }
        public List<JobAdvertisement> GetWithChild()
        {
            return db.JobAdvertisements
                .Include(x => x.OnlineJobSite)
                .Include(x => x.JobApplicants)
                .ToList();
        }

        public JobAdvertisement Get(int id)
        {
            return db.JobAdvertisements.FirstOrDefault(x => x.JobAdvertisementId == id);
        }

        public List<JobAdvertisement> GetAdvertiseeOptions(int jobsiteId)
        {
            return db.JobAdvertisements.Where(c => c.OnlineJobSiteId == jobsiteId).ToList();
        }

        public List<OnlineJobSite> GetJobSiteList()
        {
            return db.OnlineJobSites.ToList();
        }

        public bool Insert(JobAdvertisement ja)
        {
            db.JobAdvertisements.Add(ja);
            return db.SaveChanges() > 0;
        }

        public bool InsertApplicant(JobApplicant[] applicants)
        {
            db.JobApplicants.AddRange(applicants);
            return db.SaveChanges() > 0;
        }

        public bool Update(JobAdvertisement ja)
        {
            db.Entry(ja).State = EntityState.Modified;
            return db.SaveChanges() > 0;
        }
        public bool Delete(int id)
        {
            db.Entry(new JobAdvertisement { JobAdvertisementId = id }).State = EntityState.Deleted;
            return db.SaveChanges() > 0;
        }

        public JobAdvertisement GetWithChild(int id)
        {
            return db.JobAdvertisements
                .Include(x => x.OnlineJobSite)
                .Include(x => x.JobApplicants)
                .FirstOrDefault(x => x.JobAdvertisementId == id);
        }

        public bool UpdateWithChild(JobAdvertisement ja)
        {
            var orignal = db.JobAdvertisements.Include(x => x.JobApplicants).First(x => x.JobAdvertisementId == ja.JobAdvertisementId);
            orignal.OnlineJobSiteId = ja.OnlineJobSiteId;
            orignal.JobTypeName = ja.JobTypeName;
            orignal.Responsibility = ja.Responsibility;

            if (ja.JobApplicants != null && ja.JobApplicants.Count > 0)
            {
                var applicants = ja.JobApplicants.ToArray();
                for (var i = 0; i < applicants.Length; i++)
                {
                    var temp = orignal.JobApplicants.FirstOrDefault(x => x.JobApplicantId == applicants[i].JobApplicantId);
                    if (temp != null)
                    {
                        temp.JobApplicantName = applicants[i].JobApplicantName;
                        
                        temp.ContactEmail = applicants[i].ContactEmail;
                    }
                    else
                    {
                        orignal.JobApplicants.Add(applicants[i]);
                    }
                }
                var originalJobApplicants = orignal.JobApplicants.ToArray();
                for (var i = 0; i < originalJobApplicants.Length; i++)
                {
                    var temp = ja.JobApplicants.FirstOrDefault(t => t.JobApplicantId == originalJobApplicants[i].JobApplicantId);
                    if (temp == null)
                        db.JobApplicants.Remove(originalJobApplicants[i]);
                }
            }
            //db.Entry(c).State = EntityState.Modified;
            return db.SaveChanges() > 0;
        }
    }
    }

