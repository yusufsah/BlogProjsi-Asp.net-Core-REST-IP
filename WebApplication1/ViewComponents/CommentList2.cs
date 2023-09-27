using bussineslayer.contrete;
using dataacseslayer.entityframwork;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;
using WebApplication1.Models;

namespace WebApplication1.ViewComponents
{
	public class CommentList2 : ViewComponent
	{

		CommentManeger cm = new CommentManeger(new EFcommentRepository());
		public IViewComponentResult Invoke(int id)
		{

			var valuse = cm.GETLİST(id);

			return View(valuse);

		}




	}
}
