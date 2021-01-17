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
    public class JobApplicantController : Controller
    {
        IJobApplicant applicantRepo = null;
        public JobApplicantController(IJobApplicant _applicantRepo) { this.applicantRepo = _applicantRepo; }
        public IActionResult Index()
        {
            var data = this.applicantRepo.GetAll();
            return View(data);
        }
        //[Authorize]
        public IActionResult Create()
        {
            ViewBag.advertises = this.applicantRepo.GetAdvertisement();
            return View();
        }
        [HttpPost]
        public IActionResult Create(JobApplicant p)
        {
            if (ModelState.IsValid)
            {
                this.applicantRepo.Insert(p);
                return RedirectToAction("Index");
            }
            ViewBag.advertises = this.applicantRepo.GetAdvertisement();
            return View();
        }
        [Authorize]
        public IActionResult Edit(int id)
        {
            ViewBag.advertises = this.applicantRepo.GetAdvertisement();
            var data = this.applicantRepo.GetJobApplicantById(id);
            return View(data);
        }
        [HttpPost]
        public IActionResult Edit(JobApplicant p)
        {
            if (ModelState.IsValid)
            {
                this.applicantRepo.Edit(p);
                return RedirectToAction("Index");
            }
            ViewBag.advertises = this.applicantRepo.GetAdvertisement();
            return View();
        }
        public ActionResult Delete(int id)
        {

            return View(applicantRepo.GetJobApplicantById(id));
        }
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirm(int id)
        {
            if (ModelState.IsValid)
            {
                applicantRepo.Delete(id);
                return RedirectToAction("Index");
            }

            return View();
        }
    }
}