using Microsoft.AspNetCore.Mvc;

namespace RazorApp.Controllers
{
    public class RazorController : Controller
    {
        [HttpGet("")]
        public ViewResult Index() => View("Index");

    }
}