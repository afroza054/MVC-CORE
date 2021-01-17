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
    public class OnlineJobSiteController : Controller
    {
        IOnlineJobSite onlineRepo = null;
        public OnlineJobSiteController(IOnlineJobSite _onlineRepo) { this.onlineRepo = _onlineRepo; }
        public IActionResult Index()
        {
            var data = this.onlineRepo.GetAll();
            return View(data);
        }
        //[Authorize]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(OnlineJobSite o)
        {
            if(ModelState.IsValid)
            {
                this.onlineRepo.Insert(o);
                return RedirectToAction("Index");
            }
            return View();
        }
        [Authorize]
        public IActionResult Edit(int id)
        {
            var data = this.onlineRepo.GetOnlineJobSiteById(id);
            return View(data);
        }
        [HttpPost]
        public IActionResult Edit(OnlineJobSite o)
        {
            if (ModelState.IsValid)
            {
                this.onlineRepo.Edit(o);
                return RedirectToAction("Index");
            }
            return View();
        }
        public ActionResult Delete(int id)
        {

            return View(onlineRepo.GetOnlineJobSiteById(id));
        }
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirm(int id)
        {
            if (ModelState.IsValid)
            {
                onlineRepo.Delete(id);
                return RedirectToAction("Index");
            }

            return View();
        }
    }
}