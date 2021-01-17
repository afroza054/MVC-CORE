using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Project_Work_2.Models;

namespace Project_Work_2.Repo
{

    public class JobApplicantRepo : IJobApplicant
    {
        JobDbContext db = null;
        public JobApplicantRepo(JobDbContext db) { this.db = db; }
        public void Delete(int id)
        {
            db.Entry(new JobApplicant { JobApplicantId = id }).State = EntityState.Deleted;
            db.SaveChanges();
        }

        public void Edit(JobApplicant p)
        {
            db.Entry(p).State = EntityState.Modified;
            db.SaveChanges();
        }

        public List<JobAdvertisement> GetAdvertisement()
        {
            return db.JobAdvertisements.ToList();
        }

        public List<JobApplicant> GetAll()
        {
            return db.JobApplicants.Include(x => x.JobAdvertisement).ToList();
        }

        public JobApplicant GetJobApplicantById(int id)
        {
            return db.JobApplicants.Include(x => x.JobAdvertisement).ToList().FirstOrDefault(x => x.JobApplicantId == id);
        }

        public void Insert(JobApplicant p)
        {
            db.JobApplicants.Add(p);
            db.SaveChanges();
        }
    }
}
