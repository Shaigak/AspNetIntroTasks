using Microsoft.AspNetCore.Mvc;

namespace AspNetTasks.Controllers
{
    public class CalculateController : Controller
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
