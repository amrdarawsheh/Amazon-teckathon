using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace JobsAbility.Controllers
{
    public class ApiController : Controller
    {
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
