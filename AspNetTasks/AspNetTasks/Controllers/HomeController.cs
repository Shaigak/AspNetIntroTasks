using Microsoft.AspNetCore.Mvc;

namespace AspNetTasks.Controllers
{
    public class HomeController:Controller
    {
        public IActionResult Index()
        {
            //int[] nums = new int[20];

            //for(int  i=0; i<20;  i++)
            //{
            //    if (i % 2 == 1)
            //    {
            //        nums[i] = i;
            //    }
                

            //}

            return View();
        }

    }
}


