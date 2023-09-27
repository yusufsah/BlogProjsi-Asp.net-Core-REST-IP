using bussineslayer.contrete;
using bussineslayer.validationrules;
using dataacseslayer.concreat;
using dataacseslayer.entityframwork;
using entity.conti;
using FluentValidation.AspNetCore;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
    
{
    [AllowAnonymous]
    public class WriterController : Controller
    {
        WriterManeger mn = new WriterManeger(new EFwriterRepository());

       
        public IActionResult Index()  //program bölümünde yaptık//  ama bunu program bölümünde ekledik
        {
            var usermail = User.Identity.Name;   // burası  ıd göre  giriş yapma  kısmı
            ViewBag.use = usermail;
            context c= new context();
            var writername = c.writers.Where(x => x.writermail==usermail).Select(y=>y.yazarName).FirstOrDefault();
            ViewBag.writername1 = writername;

            return View();
        }


        //
        [AllowAnonymous] // yoksa çalışmaz
        public IActionResult text()  //test eymek için kurdum // burası yazar paneli
        {
            return View();
        }


        //
        [AllowAnonymous]
        public PartialViewResult writernavbarpartial()   // burası yazar panel 1. patial
        {


            return PartialView();
        }
        //
        [AllowAnonymous]
        public PartialViewResult writerfooterpartial2()   // burası yazar panel 2. patial
        {


            return PartialView();
        }
        ///
        /// /////////////////



     
        [HttpGet]
        public IActionResult writerprofil()   //profilsayfamız
        {
            var usermail = User.Identity.Name;

            context c = new context();

            var writerID = c.writers.Where(x => x.writermail == usermail).Select(y => y.yazarID).FirstOrDefault();
            ViewBag.writerID1 = writerID;

            var writervalues = mn.TgetbyID(writerID);

            return View(writervalues);
        }

        
        [HttpPost]
       
        public IActionResult writerprofil(writer p)
        {
            
                mn.Tupdate(p);
               return RedirectToAction("Index", "Dashboard");
          
        }

    }
}