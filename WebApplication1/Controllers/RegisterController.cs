using bussineslayer.contrete;
using bussineslayer.validationrules;
using dataacseslayer.entityframwork;
using entity.conti;
using FluentValidation.AspNetCore;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
	public class RegisterController : Controller
	{
		WriterManeger cm = new WriterManeger(new EFwriterRepository());


		//kayıt ilemi için  [HttpGet] ve [HttpPost] kulalnıcaz get site açıldığında  [HttpPost]  butna basıldığında


		[HttpGet]   // bunu unutma kontrol amaçlı
		public IActionResult Index()
		{
			


			return View();


		}
		[HttpPost]
		public IActionResult Index(writer p)
		{   
			// unutma burası çok kolay kafan karışmasın 

			// burası  WriterValidator sınıfındaki şartları yerine geitrsin diye 
			WriterValidator  wv= new WriterValidator();

			ValidationResult result = wv.Validate(p);



			


				//// buras aşşağısı  boş kalan yerleri doldurma için  şirfe girerken yazarın biligleri
				/// ekrana ile balnatıyı burdakiler sağlıyor
				p.writerstatuc = "text";
				p.writerabout = "text";

				cm.Tadd(p);

				return RedirectToAction("Index", "blogController1");


		}


	}
}
