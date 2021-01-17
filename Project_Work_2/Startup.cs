using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Project_Work_2.BILL;
using Project_Work_2.Models;
using Project_Work_2.Repo;

namespace Project_Work_2
{
    public class Startup
    {
        public Startup(IConfiguration Config) { this.Config = Config; }
        public IConfiguration Config { get; set; }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });
            services.AddDbContext<JobDbContext>(o => o.UseSqlServer(this.Config.GetConnectionString("job")));

            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(this.Config.GetConnectionString("DefaultConnection")));

            services.AddDefaultIdentity<IdentityUser>()
                .AddDefaultUI(UIFramework.Bootstrap4)
                .AddEntityFrameworkStores<ApplicationDbContext>();

            services.AddScoped<IOnlineJobSite, OnlineJobSiteRepo>();
            services.AddScoped<IJobAdvertisement, JobAdvertiseRepo>();
            services.AddScoped<IOnlineRepo, OnlineSiteRepo>();
            services.AddScoped<IAdvertise, AdvertiseRepo>();
            services.AddScoped<IJobApplicant, JobApplicantRepo>();
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, JobDbContext db)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            if (!db.Database.CanConnect())
            {
                if (db.Database.EnsureCreated())
                {
                    new DbInitializer().Seed(db);
                }
            }
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseAuthentication();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
            
        }
    }
}
