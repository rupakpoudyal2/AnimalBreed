using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Animal.Models;
using Animal.Repository;
using Microsoft.AspNetCore.Http;

namespace Animal.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRepository<feedFooder> _repo;

        public HomeController(IRepository<feedFooder> repo)
        {
            _repo = repo;
        }


        public IActionResult feedFooder()
        {
            IEnumerable<feedFooder> all = _repo.GetModel();
            return View(all);
        }

        [HttpGet]
        public IActionResult AddEditStudent(int? id)
        {
            feedFooder model = new feedFooder();
            if (id.HasValue)
            {
                feedFooder feed = _repo.GetById(id.Value);
                if (feed != null)
                {
                    model = feed;
                }
            }
            return View(model);
        }
        [HttpPost]
        public ActionResult AddEditStudent(int? id, feedFooder model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    bool isNew = !id.HasValue;
                    feedFooder feed = isNew ? new feedFooder { } : _repo.GetById(id.Value);
                    feed = model;
                    if (isNew)
                    {
                        _repo.Insert(feed);
                        _repo.Save();
                    }
                    else
                    {
                        _repo.Update(model);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult DeleteFeed(int id)
        {
            feedFooder feed = _repo.GetById(id);
            _repo.Delete(id);

            return RedirectToAction("Index");

        }
        //[HttpPost]
        //public IActionResult DeleteFeed(int id, FormCollection form)
        //{
        //    _repo.Delete(id);
           
        //}
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
