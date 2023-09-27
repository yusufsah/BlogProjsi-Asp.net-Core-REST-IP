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

namespace WebApplication1.Controllers
{
	
	public class BlogController1 : Controller
	{

		BlogManeger cm= new BlogManeger(new EFblogRepository());

        [AllowAnonymous]
        public IActionResult Index()     // blog3 ün ana sayfası bu  indexi herşey ana bağlı
		{
			var values = cm.getbloglistWithKataogri();  // bunuda katagoriler getirlbilmek için yaptık
                          
            return View(values);
		}



		[AllowAnonymous]
		public IActionResult BlogReadall(int id) // blogmanegar kısmında değiştiklik yaptım 
		{
			ViewBag.i = id;   // yorumları   id lerine göre yazdırmak için yazdırmak için 

			var value=cm.getblogbyID(id);  //burası ikinci sayfamızı  oluşturduk

			return View(value);

		}


        public IActionResult Bloglistbywriterpanel() //  yaraz paneli içinde blogları  getiren sayfa
        { // kullanıcıya göre getirme
            var usermail = User.Identity.Name;

            context c = new context();

            var writerID = c.writers.Where(x => x.writermail == usermail).Select(y => y.yazarID).FirstOrDefault();
            ViewBag.writerID1 = writerID;


            var values=cm.test(writerID);

            return View(values);

           

        }


        //BURAYI AYIRMA SEBEBİM BURASI YAZAR PANELİNDE YAZADAR ID İLE YORUM EKLE OLUCAK VE HTTPGET VE POST KULLANICAK
        /// /////////////////////////////////////////////////////////////////////////////////
        [AllowAnonymous]
        [HttpGet]
        public IActionResult blogADDwriterpanel() //  blog ekleme PANEL ÜZERİNDEN
        {
            katagoriManeger cv = new katagoriManeger(new EFkataogriRepository());

            List<SelectListItem> katagorivalues = (from x in cv.GETLİST()

                                                   select new SelectListItem
                                                   {
                                                   Text= x.katagoriName,
                                                   Value=x.katagoriID.ToString(),
                                                   }).ToList();

            ViewBag.i = katagorivalues;
            return View();

        }
        [AllowAnonymous]
        [HttpPost]
        public IActionResult blogADDwriterpanel(blog p) //  
        {
            var usermail = User.Identity.Name;

            context c = new context();

            var writerID = c.writers.Where(x => x.writermail == usermail).Select(y => y.yazarID).FirstOrDefault();
            ViewBag.writerID1 = writerID;





            blogvalidator wv = new blogvalidator();

            ValidationResult result = wv.Validate(p);

		
                //// buras aşşağısı  boş kalan yerleri doldurma için  şirfe girerken yazarın biligleri
                /// ekrana ile balnatıyı burdakiler sağlıyor
                p.creatdate = DateTime.Parse(DateTime.Now.ToShortTimeString());
                p.yazarID = writerID;  // yukardaki kişiye göre getir bölümünden
         
               
                


                cm.Tadd(p);

                return RedirectToAction("Bloglistbywriterpanel", "blogController1");
      

        }

        /////////////////////////////////////////////////////////////////////////////////////
        [AllowAnonymous]
        public IActionResult deleteblog(int id) // delete işemi  içim çalışıyor
        {


            var value=cm.TgetbyID(id);
            cm.Tdelete(value);

            return RedirectToAction("Bloglistbywriterpanel", "blogController1");

        }
        /////////////////////////////////////////////////////////////

        [AllowAnonymous]
        [HttpGet]
        public IActionResult editblog(int id)
        {
            katagoriManeger cv = new katagoriManeger(new EFkataogriRepository());
            var value = cm.TgetbyID(id);
           

            List<SelectListItem> katagorivalues = (from x in cv.GETLİST()

                                                   select new SelectListItem
                                                   {
                                                       Text = x.katagoriName,
                                                       Value = x.katagoriID.ToString(),
                                                   }).ToList();

            ViewBag.i = katagorivalues;
          

            return View(value);  

        }

        [AllowAnonymous]
        [HttpPost]
        public IActionResult editblog(blog p)
        {
            var usermail = User.Identity.Name;

            context c = new context();

            var writerID = c.writers.Where(x => x.writermail == usermail).Select(y => y.yazarID).FirstOrDefault();
            ViewBag.writerID1 = writerID;




            p.yazarID = writerID;
            p.creatdate = DateTime.Parse(DateTime.Now.ToShortTimeString());
            cm.Tupdate(p);
            return RedirectToAction("Bloglistbywriterpanel", "blogController1");

        }
        //////////////////////////////////////////////////////////////////////////////////
        ///




        




    }
}
