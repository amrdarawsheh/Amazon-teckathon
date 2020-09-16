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
using Microsoft.EntityFrameworkCore;
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
            using (var db = new jobsDBContext())
            {
                var jobs = new List<JobDTO>();
                var jobposts = db.JobPostings.ToList();
                foreach (var jobpost in jobposts)
                {
                    var companyName = db.Users.Include(a => a.Company).Where(a => a.Id == jobpost.RecruiterId).OrderByDescending(a=>a.Id).Select(a => new { a.Company.Name, a.Company.Location }).FirstOrDefault();
                    jobs.Add(new JobDTO
                    {
                        Id = jobpost.Id,
                        Company = companyName.Name,
                        Date = jobpost.AddedDate.ToShortDateString(),
                        Details = jobpost.Details,
                        LocationLink = companyName.Location,
                        Title = jobpost.Title,
                        isDeaf = jobpost.IsDeaf,
                        isBlind = jobpost.IsBlind,
                        isAll = jobpost.IsAll
                    });
                }
                return View(jobs);
            }
        }
        public IActionResult JobDescription(int id)
        {
            using (var db=new jobsDBContext())
            {
                var jobpost = db.JobPostings.FirstOrDefault(a=>a.Id==id);
                var companyName = db.Users.Include(a => a.Company).Where(a => a.Id == jobpost.RecruiterId).Select(a => new { a.Company.Name, a.Company.Location}).FirstOrDefault();
                var jobDTO = new JobDescriptionDTO
                {
                    Id = jobpost.Id,
                    Company = companyName.Name,
                    Date = jobpost.AddedDate.ToShortDateString(),
                    Details = jobpost.Details,
                    LocationLink = companyName.Location,
                    Title = jobpost.Title
                };
                return View(jobDTO);
            }
        }
      
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Logout()
        {
            HttpContext.Session.Remove("UserId");
            HttpContext.Session.Remove("Role");
            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult Login(string email,string password)
        {
            using (var db = new jobsDBContext())
            {
                var user = db.Users.FirstOrDefault(a=>a.Email.ToLower()==email.ToLower()&&a.Password==password);
                if (user == null)
                {
                    ViewBag.error = "error";
                    return View();
                }
                else
                {
                    HttpContext.Session.SetString("UserId", user.Id+"");
                    HttpContext.Session.SetString("Role", user.RoleId+"");
                    HttpContext.Session.SetString("Name", user.Firstname+" "+user.Lastname);
                    if (user.RoleId == 1)
                    {
                        return RedirectToAction("managejobs");
                    }
                    else if(user.RoleId == 2)
                    {
                        return RedirectToAction("jobs");
                    }
                    else
                    {
                        return RedirectToAction("jobs");
                    }
                }
            }
        }
        public IActionResult Signup()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Apply(int id)
        {
            int userId = -1;
            if (int.TryParse(HttpContext.Session.GetString("UserId"), out userId) && int.TryParse(HttpContext.Session.GetString("Role"), out int roleId) && roleId == 2)
            {
                using (var db = new jobsDBContext())
                {
                    var jobapp = new JobApplications
                    {
                        JobPostingId = id,
                        ApplicantId = id,
                    };
                    db.JobApplications.Add(jobapp);
                    db.SaveChanges();
                    return View();
                }
            }
            else
            {
                return RedirectToAction("Login");
            }

        }
        public IActionResult ManageJobs()
        {
            int userId = -1;
            if (int.TryParse(HttpContext.Session.GetString("UserId"), out userId) && int.TryParse(HttpContext.Session.GetString("Role"), out int roleId) && roleId == 1)
            {
                using (var db = new jobsDBContext())
                {
                    var jobPosts = new List<ManageJobDTO>();
                    var jobposts = db.JobPostings.Where(a=>a.RecruiterId==userId).ToList();
                    foreach (var jobPost in jobposts)
                    {
                        int numOfApplicants = db.JobApplications.Where(a => a.JobPostingId == jobPost.Id).Count();
                        jobPosts.Add(new ManageJobDTO
                        {
                            Id=jobPost.Id,
                            NoApp=numOfApplicants,
                            Status=jobPost.IsActive?"Active":"Inactive",
                            Title=jobPost.Title
                        });
                    }
                    return View(jobPosts);
                }
            }
            else
            {
                return RedirectToAction("Login");
            }
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
                JobPost.IsActive = true;
                JobPost.AddedDate = DateTime.Now;
                db.JobPostings.Add(JobPost);
                db.SaveChanges();
                return RedirectToAction("ManageJobs");
            }
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ManageApplicants(int id)
        {
            int userId = -1;
            if (int.TryParse(HttpContext.Session.GetString("UserId"), out userId) && int.TryParse(HttpContext.Session.GetString("Role"), out int roleId) && roleId == 1)
            {
                using (var db=new jobsDBContext())
                {
                    ViewBag.jobTitle = db.JobPostings.Where(a => a.Id == id).Select(a => a.Title).FirstOrDefault();
                    var applicants = db.JobApplications.Include(a => a.Applicant).Include(a => a.Applicant.Disability).Where(a=>a.JobPostingId==id).Select(a => new ApplicantDTO {
                        Id = a.Applicant.Id,
                        Name = a.Applicant.Firstname + " " + a.Applicant.Lastname,
                        DisabilityId = (a.Applicant.DisabilityId == null ? 4 : (int)a.Applicant.DisabilityId)
                    }).ToList();
                    return View(applicants);
                }
            }
            else
            {
                return RedirectToAction("login");
            }
        }
        
        public IActionResult MyJobs()
        {
            int userId = -1;
            if (int.TryParse(HttpContext.Session.GetString("UserId"), out userId) && int.TryParse(HttpContext.Session.GetString("Role"), out int roleId) && roleId == 2)
            {
                using (var db = new jobsDBContext())
                {
                    var jobs = new List<JobDTO>();
                    var jobposts = db.JobApplications.Include(a => a.JobPosting).Where(a => a.ApplicantId ==userId).Select(a=>a.JobPosting).ToList();
                    foreach (var jobpost in jobposts)
                    {
                        var companyName = db.Users.Include(a => a.Company).Where(a => a.Id == jobpost.RecruiterId).Select(a => new { a.Company.Name, a.Company.Location }).FirstOrDefault();
                        jobs.Add(new JobDTO
                        {
                            Id = jobpost.Id,
                            Company = companyName.Name,
                            Date = jobpost.AddedDate.ToShortDateString(),
                            Details = jobpost.Details,
                            LocationLink = companyName.Location,
                            Title = jobpost.Title,
                            isDeaf = jobpost.IsDeaf,
                            isBlind = jobpost.IsBlind,
                            isAll = jobpost.IsAll
                        });
                    } 
                    return View(jobs);
                }
            }
            else
            {
                return RedirectToAction("Login");
            }
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
