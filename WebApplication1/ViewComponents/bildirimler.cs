using bussineslayer.contrete;
using dataacseslayer.entityframwork;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.ViewComponents
{
	public class bildirimler : ViewComponent

	{ 
		BlogManeger cm = new BlogManeger(new EFblogRepository());
		public IViewComponentResult Invoke() 
		{

			

			return View();

		}
	}
}
