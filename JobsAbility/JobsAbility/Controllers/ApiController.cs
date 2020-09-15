using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace JobsAbility.Controllers
{
    public class ApiController : Controller
    {
        [HttpGet]
        public void LoginAs(string id,string role)
        {
            HttpContext.Session.SetString("UserId", id);
            HttpContext.Session.SetString("Role", role);
            var test = HttpContext.Session.GetString("UserId");
            var test1 = HttpContext.Session.GetString("Role");
        }
        [HttpGet]
        public JsonResult Polly(string text)
        {
            try
            {
                var mp3Link = PollyHelper.GetSentenceMp3(text);
                return new JsonResult(new JsonDTO
                {
                    result = "ok",
                    mp3Link = mp3Link
                });
            }
            catch (Exception ex)
            {
                return new JsonResult(new JsonDTO
                {
                    result = "error",
                    mp3Link = ex.Message
                });
            }
        }
    }
}
