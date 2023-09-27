using bussineslayer.contrete;
using dataacseslayer.entityframwork;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.ViewComponents
{
	public class last3post :ViewComponent

	{
		BlogManeger cm = new BlogManeger(new EFblogRepository());
		public IViewComponentResult Invoke()  
		{

			var valuse = cm.getlast3blog();

			return View(valuse);

		}
	}
}
