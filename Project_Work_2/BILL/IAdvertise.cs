using Project_Work_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_Work_2.BILL
{
    public interface IAdvertise
    {
        List<JobAdvertisement> Get();
        List<JobAdvertisement> GetWithChild();
        JobAdvertisement Get(int id);
        JobAdvertisement GetWithChild(int id);
        List<OnlineJobSite> GetJobSiteList();
        List<JobAdvertisement> GetAdvertiseeOptions(int jobsiteId);
        bool Insert(JobAdvertisement ja);
        bool Update(JobAdvertisement ja);
        bool UpdateWithChild(JobAdvertisement ja);
        bool Delete(int id);
        bool InsertApplicant(JobApplicant[] applicants);
    }
}
