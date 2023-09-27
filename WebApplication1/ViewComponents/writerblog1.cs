using bussineslayer.contrete;
using dataacseslayer.entityframwork;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.ViewComponents
{
	public class writerblog1 : ViewComponent
	{

		BlogManeger cm = new BlogManeger(new EFblogRepository());
		public IViewComponentResult Invoke()
		{

			var valuse = cm.GetBloglistbyWriter(1);

			return View(valuse);

		}
	}
}
