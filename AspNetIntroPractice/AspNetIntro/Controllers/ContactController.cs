using Microsoft.AspNetCore.Mvc;

namespace AspNetIntro.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
