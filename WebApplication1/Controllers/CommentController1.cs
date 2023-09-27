using bussineslayer.contrete;
using dataacseslayer.entityframwork;
using entity.conti;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
	public class commentcontroller1 : Controller
	{

		CommentManeger cm = new CommentManeger(new EFcommentRepository());

		public IActionResult Index()
		{
			return View();
		}
		[HttpGet]
		public PartialViewResult partialaddcomment()
		{


			return PartialView();
		}

		[HttpPost]
		public PartialViewResult partialaddcomment(comment p)
		{
			p.commentDate = DateTime.Parse(DateTime.Now.ToShortDateString());
			p.commentstatus = "true";
			p.blogID = 14;
			cm.addcomment(p);



			return PartialView();
		}

	}
}
