using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Project_Work_2.BILL;
using Project_Work_2.Models;

namespace Project_Work_2.Controllers
{
    public class AdvertisementController : Controller
    {
        IAdvertise repo;
        public AdvertisementController(IAdvertise repo) { this.repo = repo; }
        public IActionResult Index(int jobsiteId = 0)
        {
             
            var list = repo.GetJobSiteList();
            list.Insert(0, new OnlineJobSite { OnlineJobSiteId = 0, OnlineJobSiteName = "All" });
            ViewBag.JobSites = list;
            var data = repo.GetWithChild();
            if (jobsiteId > 0)
            {
                return View(data.Where(x => x.OnlineJobSiteId == jobsiteId).ToList());
            }
            return View(data);
        }
        //[Authorize]
        public IActionResult Create()
        {
            var list = repo.GetJobSiteList();
            list.Insert(0, new OnlineJobSite { OnlineJobSiteId = 0, OnlineJobSiteName = "Select" });
            ViewBag.JobSites = list;
            return View();
        }
        public IActionResult GetAdvertiseeOptions(int id)
        {
            var data = repo.GetAdvertiseeOptions(id);
            data.Insert(0, new JobAdvertisement { JobAdvertisementId = 0, JobTypeName = "Select" });
            return Json(data);
        }
        public IActionResult SaveApplicants([FromBody] JobApplicant[] applicants)
        {
            if (ModelState.IsValid)
            {
                repo.InsertApplicant(applicants);
                return Json(new { success = true, data = "Saved" });
            }
            return Json(new { success = false, data = "Error" });
        }
        public IActionResult Edit(int id)
        {
            var list = repo.GetJobSiteList();
            //list.Insert(0, new Trade { TradeId = 0, TradeName = "Select" });
            ViewBag.JobSites = list;
            var data = repo.GetWithChild(id);
            return View(data);
        }
        [HttpPost]
        public IActionResult SaveJobAdvertisement([FromBody]JobAdvertisement ja)
        {
            if (ModelState.IsValid)
            {
                repo.UpdateWithChild(ja);
                return Json(new { success = true });
            }
            return Json(new { success = false });
        }
        public IActionResult Delete(int id)
        {
            return View(repo.GetWithChild(id));
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DoDelete(int id)
        {
            repo.Delete(id);
            return RedirectToAction("Index");
        }

    }
}