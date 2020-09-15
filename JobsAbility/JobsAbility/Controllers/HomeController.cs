using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using JobsAbility.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Http;

namespace JobsAbility.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public IActionResult Jobs()
        {
            return View();
        }
        public IActionResult JobDescription()
        {
            return View();
        }
        public IActionResult TypicalChat()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Signup()
        {
            return View();
        }
        public IActionResult Apply()
        {
            return View();
        }
        public IActionResult ManageJobs()
        {
            return View();
        }
        public IActionResult CreateJobs()
        {

            if (int.TryParse(HttpContext.Session.GetString("UserId"), out int userId) && int.TryParse(HttpContext.Session.GetString("Role"), out int roleId) && roleId == 1) 
            {
                List<SelectListItem> categories = new List<SelectListItem>();
                using (var db = new jobsDBContext())
                {
                    categories = db.Categories.Select(a => new SelectListItem { Value = a.Id.ToString(), Text = a.Name }).ToList();
                    ViewBag.categories = categories;
                    return View();
                }
            }
            else
            {
                return View("Login");
            }
        }
        [HttpPost]
        public IActionResult CreateJobs(JobPostings JobPost)
        {
            using (var db = new jobsDBContext())
            {
                var userId =int.Parse(HttpContext.Session.GetString("UserId"));
                JobPost.RecruiterId = userId;
                db.JobPostings.Add(JobPost);
                db.SaveChanges();
                return View("ManageJobs");
            }
        }
        public IActionResult Index()
        {
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
