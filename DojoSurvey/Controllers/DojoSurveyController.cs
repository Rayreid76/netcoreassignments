using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
namespace DojoSurvey.Controllers
{
    public class DojoSurveyController : Controller
    {
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            return View("Index");
        }

        [HttpPost]
        [Route("data")]
        public IActionResult processform(string fullName, string dojolocation, string language, string comment)
        {
            object postsurvey = new
            {
                Fname = fullName,
                loca = dojolocation,
                lang = language,
                comm = comment
            };
            return Json(postsurvey);
        }
    }
}
