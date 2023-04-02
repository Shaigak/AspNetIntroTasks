using Microsoft.AspNetCore.Mvc;

namespace AspNetIntro.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
