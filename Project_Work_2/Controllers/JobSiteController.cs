using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Project_Work_2.BILL;
using Project_Work_2.Models;

namespace Project_Work_2.Controllers
{
    public class JobSiteController : Controller
    {
        //[Authorize]
        IOnlineRepo repo;
        public JobSiteController(IOnlineRepo repo) { this.repo = repo; }
        public IActionResult Index()
        {
            var data = repo.GetWithChildred();
            return View(data);
        }
        public IActionResult CreateTradeWithCourse()
        {
            return View();
        }
        public IActionResult CreateTradeWithCourse1()
        {
            return View();
        }
        [HttpPost]
        public JsonResult CreateTradeWithCourse([FromBody]OnlineJobSite t)
        {
            if (ModelState.IsValid)
            {
                if (repo.Insert(t))
                    return Json(new { success = true });
                else
                    return Json(new { success = false });
            }
            else
            {
                return Json(new { success = false });
            }
            //return View();
        }
        public IActionResult GetCourseAddForm()
        {
            return PartialView("_AdvertiseAddRow");
        }
        public IActionResult Create(string postBack = "")
        {
            if (postBack != "")
            {
                ViewBag.PostBack = "Success";
            }
            return View();
        }
        [HttpPost]
        public IActionResult Create(OnlineJobSite t)
        {
            if (ModelState.IsValid)
            {
                if (repo.Insert(t))
                {
                    return RedirectToAction("Create", new { postBack = "postBack" });
                }
            }
            return View(t);
        }
        public IActionResult EditWithCourse(int id)
        {
            var data = repo.Get(id);
            if (data == null)
                return NotFound();
            return View(data);
        }
        [HttpPost]
        public IActionResult EditWithCourse([FromBody]OnlineJobSite t)
        {
            if (ModelState.IsValid)
            {
                if (repo.Update(t))
                    return Json(new { success = true });

            }
            return Json(new { success = false });

        }
    }
}