using dataacseslayer.entityframwork;
using bussineslayer.contrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using NuGet.Protocol;
using entity.conti;
using bussineslayer.validationrules;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using dataacseslayer.concreat;
using X.PagedList;

namespace WebApplication1.Controllers
{
    public class katagori : Controller
    {

        katagoriManeger cm= new katagoriManeger( new EFkataogriRepository());

        [AllowAnonymous]
        public IActionResult Index(int page =1)
        {


            var value = cm.GETLİST().ToPagedList(page,3);

            return View(value);

           

        }
      
        /// ///////////////////////////////////
   
        [HttpGet]
        public IActionResult katagroiekle()
        {

            return View();
        }
        [HttpPost]
        public IActionResult katagroiekle(katagori p)
        {
          

             // çalışmadı
            

         

            return RedirectToAction("Bloglistbywriterpanel", "blogController1");

        }
      
        /// //////////////////////////////////////////////
       
        public IActionResult katagorisil(int id)
        {
            
            var valuer = cm.TgetbyID(id);
            cm.Tdelete(valuer);

            return RedirectToAction("Index", "katagori");


        }









        //////////////////////////////////////////////////////////////////
        /// ///BURASI DENEME PROJE İLE İLGİSİ YOK 
        ///



        [AllowAnonymous]
        public IActionResult DENEM1()
        {


            var value = cm.GETLİST();

            return View(value);




            return View(value);



        }
        [AllowAnonymous]
        [HttpGet]
        public IActionResult DENEM1EKLEME()
        {



            return View();



        }

        [HttpPost]
        public IActionResult DENEM1EKLEME(entity.conti.katagori p)
        {



                  ViewBag.i = new List<SelectListItem>
{
                new SelectListItem { Value = "value1", Text = "text1" },
                new SelectListItem { Value = "value2", Text = "text2" },
                  // Diğer SelectListItem öğeleri burada eklenebilir.
};



            cm.Tadd(p);

            return View();



        }







    }


}









