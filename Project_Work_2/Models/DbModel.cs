using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Project_Work_2.Models
{
    public class OnlineJobSite
    {
        //1
        public OnlineJobSite()
        {
            this.JobAdvertisements = new List<JobAdvertisement>();
        }
        [Display(Name = "Job Site ID")]
        public int OnlineJobSiteId { get; set; }

        [Required, StringLength(50), Display(Name = "Name of JobSite")]
        public string OnlineJobSiteName { get; set; }

        [Required, Column(TypeName = "date"),
        Display(Name = "Started Journey"), DataType(DataType.Date),
        DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime StartedJourney { get; set; }

        [Display(Name = "Response Instantly")]
        public bool Web{ get; set; }

        public virtual ICollection<JobAdvertisement> JobAdvertisements { get; set; }
    }
    //2
    public class JobAdvertisement
    {
        public JobAdvertisement()
        {
            this.JobApplicants = new List<JobApplicant>();
        }
        [Display(Name = "Advertisement ID")]
        public int JobAdvertisementId { get; set; }

        [Required, StringLength(50), Display(Name = "Name of JobType")]
        public string JobTypeName { get; set; }

        [Required, StringLength(50), Display(Name = "Responsibility")]
        public string Responsibility { get; set; }

        [Required, ForeignKey("OnlineJobSite")]
        public int OnlineJobSiteId { get; set; }
        public virtual OnlineJobSite OnlineJobSite { get; set; }
        public virtual ICollection<JobApplicant> JobApplicants { get; set; }

    }
    //3
    public class JobApplicant
    {
        [Display(Name = "Applicant ID")]
        public int JobApplicantId { get; set; }

        [Required, StringLength(50), Display(Name = "Applicant Name")]
        public string JobApplicantName { get; set; }

        [Required, Display(Name = "E mail"), DataType(DataType.EmailAddress),
        StringLength(50)]
        public string ContactEmail { get; set; }
        
        [Required, ForeignKey("JobAdvertisement")]
        public int JobAdvertisementId { get; set; }
        public virtual JobAdvertisement JobAdvertisement { get; set; }
    }
    public class JobDbContext :DbContext
    {
        public JobDbContext(DbContextOptions<JobDbContext> options) : base(options) { }
        public DbSet<OnlineJobSite> OnlineJobSites { get; set; }
        public DbSet<JobAdvertisement> JobAdvertisements { get; set; }
        public DbSet<JobApplicant> JobApplicants { get; set; }
    }
    public class DbInitializer
    {
        public void Seed(JobDbContext db)
        {
            OnlineJobSite o1 = new OnlineJobSite { OnlineJobSiteName = "Bdjobs", StartedJourney = DateTime.Parse("2011-04-01").Date, Web = true };
            OnlineJobSite o2 = new OnlineJobSite { OnlineJobSiteName = "career", StartedJourney = DateTime.Parse("2013-09-06").Date, Web = false };
           
            JobAdvertisement j1 = new JobAdvertisement { JobTypeName = "Management Trainee", Responsibility = "Doing multi task" };
            j1.JobApplicants.Add(new JobApplicant { JobApplicantName = "Nusrat", ContactEmail = "nusrat@gmail.com" });
            j1.JobApplicants.Add(new JobApplicant { JobApplicantName = "Rouza", ContactEmail = "rouza2015@yahoo.com" });

            JobAdvertisement j2 = new JobAdvertisement { JobTypeName = "Senior", Responsibility = "Maintain Balance sheet" };
            j2.JobApplicants.Add(new JobApplicant { JobApplicantName = "Rately", ContactEmail = "rately@gmail.com" });
            j2.JobApplicants.Add(new JobApplicant { JobApplicantName = "Dina", ContactEmail = "dina52@yahoo.com" });
            o1.JobAdvertisements.Add(j1);
            
            o2.JobAdvertisements.Add(j2);
            
            db.OnlineJobSites.Add(o1);
            db.OnlineJobSites.Add(o2);
            db.SaveChanges();

            
        }
    }

}
