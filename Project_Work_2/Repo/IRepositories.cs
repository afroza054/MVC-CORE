using Project_Work_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_Work_2.Repo
{
    public interface IOnlineJobSite
    {
        List<OnlineJobSite> GetAll();
        void Insert(OnlineJobSite o);
        void Edit(OnlineJobSite o);
        void Delete(int id);
        OnlineJobSite GetOnlineJobSiteById(int id);
    }
    public interface IJobAdvertisement
    {
        List<JobAdvertisement> GetAll();
        void Insert(JobAdvertisement a);
        void Edit(JobAdvertisement a);
        void Delete(int id);
        JobAdvertisement GetJobAdvertisementById(int id);
        List<OnlineJobSite> GetJobSite();
    }
    public interface IJobApplicant
    {
        List<JobApplicant> GetAll();
        void Insert(JobApplicant p);
        void Edit(JobApplicant p);
        void Delete(int id);
        JobApplicant GetJobApplicantById(int id);
        List<JobAdvertisement> GetAdvertisement();
    }
}
