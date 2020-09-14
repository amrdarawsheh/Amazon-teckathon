using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace JobsAbility.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult EF()
        {
            return View();
        }
        public IActionResult MRI()
        {
            return View();
        }
        public IActionResult Polly()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Polly(string text)
        {
            var filename = Guid.NewGuid().ToString();
            PollyHelper.TextToMp3Async(text,filename);
            ViewBag.audio = filename+".mp3";
            return View();
        }



    }
}
