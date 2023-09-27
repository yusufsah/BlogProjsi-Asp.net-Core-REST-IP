using bussineslayer.contrete;
using dataacseslayer.entityframwork;
using entity.conti;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
	public class NewsLetterController : Controller
	{

		NewsLetterManeger cm = new NewsLetterManeger(new EFnewsletterRepository());

		[HttpGet]
		public PartialViewResult addmail()
		{
			return PartialView();



		}
		[HttpPost]
		public PartialViewResult addmail(Newsletter p) // bu harklı PartialViewResult unutma 
		{

			p.mailstatus = true;
			cm.addnewslitter(p);

			return PartialView();

		}
	}
}
