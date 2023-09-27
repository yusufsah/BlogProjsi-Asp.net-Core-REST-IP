using bussineslayer.contrete;
using dataacseslayer.entityframwork;
using entity.conti;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
	public class contactController : Controller
	{

		contactManeger cm = new contactManeger(new EFcontactRepository());

		[HttpGet]
		public IActionResult Index()
		{
			return View();

		}

		[HttpPost]
		public IActionResult Index(cotact p)
		{
			p.contactedate = DateTime.Parse(DateTime.Now.ToShortDateString());
			p.contactstatus = true;
			cm.contactadd(p);



			return RedirectToAction("Index", "blogController1");

		}
	}
}
