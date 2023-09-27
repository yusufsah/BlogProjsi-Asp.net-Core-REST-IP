using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class Errorpagecontroller1 : Controller
    {
        public IActionResult Index(int code)
        {
            return View();
        }
    }
}
