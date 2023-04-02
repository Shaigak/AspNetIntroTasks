using Microsoft.AspNetCore.Mvc;

namespace AspNetIntro.Controllers
{
    public class HomeController: Controller  
    {
        public IActionResult Index()
        {
            //return Json(new
            //{
            //    name = "Ali",
            //    surname = "Talibov"
            //});

            int[] nums1 = { 1, 4, 5, 6, 2, 4, 5 };
            int[] nums2 = { 11, 43, 55, 6, 2, 4, 5 };

            Data datas=new Data();
            datas.Nums1 = nums1;
            datas.Nums2 = nums2;
            return View(datas);



        }



        //public string Index(int id)
        //{

        //    if(id == 0)
        //    {
        //        return "Aqsin-";
        //    }
        //    return "Aqsin-" + id;
        //}

        //private string Getname()
        //{
        //    return "Aqsin";
        //}


        //public string Detail(string slug)
        //{
        //    return slug;
        //}



    }


    class Data
    {
        public int[] Nums1 { get; set; }
        public int[] Nums2 { get; set; }
    }
}
