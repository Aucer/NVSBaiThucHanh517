using Microsoft.AspNetCore.Mvc;

namespace FirstWeb.Controllers 
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            
            return View();
        }
        [HttpPost]
        public IActionResult Index(int SBP)
        {
            int binhphuong = SBP * SBP;
            ViewBag.message = "so binh phuong " + binhphuong;
            return View();
        }
    }
}