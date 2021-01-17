using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Project_Work_2.Models;
using Project_Work_2.Repo;

namespace Project_Work_2.Controllers
{
    //[Authorize]
    public class JobAdvertisementController : Controller
    {
        IJobAdvertisement advertiseRepo = null;
        public JobAdvertisementController(IJobAdvertisement _advertiseRepo) { this.advertiseRepo = _advertiseRepo; }
        public IActionResult Index()
        {
            var data = this.advertiseRepo.GetAll();
            return View(data);
        }
        //[Authorize]
        public IActionResult Create()
        {
            ViewBag.Onlines = this.advertiseRepo.GetJobSite();
            return View();
        }
        [HttpPost]
        public IActionResult Create(JobAdvertisement a)
        {
            if (ModelState.IsValid)
            {
                this.advertiseRepo.Insert(a);
                return RedirectToAction("Index");
            }
            ViewBag.Onlines = this.advertiseRepo.GetJobSite();
            return View();
        }
        [Authorize]
        public IActionResult Edit(int id)
        {
            ViewBag.Onlines = this.advertiseRepo.GetJobSite();
            var data = this.advertiseRepo.GetJobAdvertisementById(id);
            return View(data);
        }
        [HttpPost]
        public IActionResult Edit(JobAdvertisement a)
        {
            if (ModelState.IsValid)
            {
                this.advertiseRepo.Edit(a);
                return RedirectToAction("Index");
            }
            ViewBag.Onlines = this.advertiseRepo.GetJobSite();
            return View();
        }
        public ActionResult Delete(int id)
        {

            return View(advertiseRepo.GetJobAdvertisementById(id));
        }
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirm(int id)
        {
            if (ModelState.IsValid)
            {
                advertiseRepo.Delete(id);
                return RedirectToAction("Index");
            }

            return View();
        }
    }
}