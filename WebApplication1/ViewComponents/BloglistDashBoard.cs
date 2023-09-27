using bussineslayer.contrete;
using dataacseslayer.entityframwork;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.ViewComponents
{
	public class BloglistDashBoard : ViewComponent

	{ 
		BlogManeger cm = new BlogManeger(new EFblogRepository());
		public IViewComponentResult Invoke() 
		{

			var valuse = cm.getbloglistWithKataogri();

			return View(valuse);

		}
	}
}
