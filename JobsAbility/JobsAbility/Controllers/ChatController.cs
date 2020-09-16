using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using JobsAbility.Models;

namespace JobsAbility.Controllers
{
    public class ChatController : Controller
    {

        public IActionResult Index(int? toUserId,int? mode)
        {
            
            using (var db = new jobsDBContext())
            {
                
                int userId = -1;
                if (int.TryParse(HttpContext.Session.GetString("UserId"), out userId))
                {
                    if (toUserId == null)
                    {
                        toUserId = db.Messages.Where(a => a.ToId == userId || a.FromId == userId).OrderByDescending(a => a.Id).Select(a=>a.ToId==userId?a.FromId:a.ToId).FirstOrDefault();
                    }
                    var messages = db.Messages.Where(a => (a.FromId == userId && a.ToId == toUserId) || (a.FromId == toUserId && a.ToId == userId)).ToList();
                    ViewBag.thisUserId = userId;
                    ViewBag.toUserId = toUserId;
                    ViewBag.mode = mode??0;
                    ViewBag.toName = db.Users.Where(a => a.Id == toUserId).Select(a=>a.Firstname+" "+a.Lastname).FirstOrDefault();
                    return View(messages);
                }
                else
                {
                    return RedirectToAction("login", "home");
                }
            }
        }
        public IActionResult Create(Messages message)
        {
            using (var db = new jobsDBContext())
            {
                int userId = -1;
                if (int.TryParse(HttpContext.Session.GetString("UserId"), out userId))
                {
                    message.FromId = userId;
                    message.SendDate = DateTime.Now;
                    db.Messages.Add(message);
                    db.SaveChanges();
                }
                return Ok();
            }
        }
    }
}
