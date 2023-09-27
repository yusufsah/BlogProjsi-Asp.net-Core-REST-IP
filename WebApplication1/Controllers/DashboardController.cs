using dataacseslayer.concreat;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class DashboardController : Controller
    {
       
        public IActionResult Index()
        {
            var usermail = User.Identity.Name;

            context c = new context();

            var writerID = c.writers.Where(x => x.writermail == usermail).Select(y => y.yazarID).FirstOrDefault();

            var writeid = c.writers.Where(x => x.writermail == usermail).Select(y => y.yazarID).FirstOrDefault();



            ViewBag.v1=c.blogs.Count().ToString();   // toplam blog sayısı yazdırdık index te
            ViewBag.v2 = c.blogs.Where(x => x.yazarID == writeid).Count();
            ViewBag.v3 = c.katagoris.Count();


            return View();

        }


    }
}
