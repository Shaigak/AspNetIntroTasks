using Microsoft.AspNetCore.Mvc;

namespace AspNetTasks.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {


            string[] list = { "Saiq", "Konul", "Roya", "Anar", "Elekber" };

            
            return View(list);


        }
    }


 
}
