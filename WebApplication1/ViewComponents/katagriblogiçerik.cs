using bussineslayer.contrete;
using dataacseslayer.entityframwork;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;
using WebApplication1.Models;

namespace WebApplication1.ViewComponents
{
	public class katagriblogiçerik : ViewComponent
	{
		katagoriManeger cm = new katagoriManeger(new EFkataogriRepository());

		public IViewComponentResult Invoke()
		{

			var valuse = cm.GETLİST();   // unutma ıd kullanmadık

			return View(valuse);

		}




	}
}
