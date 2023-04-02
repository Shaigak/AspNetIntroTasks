using Microsoft.AspNetCore.Mvc;

namespace PracticeHomeForMe.Controllers
{
    public class HomeController:Controller
    {
       


        public IActionResult Index()
        {

            int a = 0, b = 1, c = 0;

            int[] nums = new int[10];

            nums[0] = a;
            nums[1] = b;

            for (int i = 2; i <10; i++)
            {
                c = a + b;

                a = b;
                b = c;
                nums[i] = c;
            }
            return View(nums);
        }

    }

}


//public IActionResult Index()
//{
//    return Json(new { name = "Ali", surname = "talibov" });
//}


//private string getName()
//{
//    return "Aqshin";
//}


//public string Detail(string slug,string name)
//{
//    return slug + name;
//}








