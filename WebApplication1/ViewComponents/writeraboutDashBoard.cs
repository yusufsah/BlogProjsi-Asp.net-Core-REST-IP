using bussineslayer.contrete;
using dataacseslayer.abstrac;
using dataacseslayer.concreat;
using dataacseslayer.entityframwork;
using entity.conti;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;
using WebApplication1.Models;

namespace WebApplication1.ViewComponents
{
	public class writeraboutDashBoard : ViewComponent
	{
		WriterManeger wr = new WriterManeger(new EFwriterRepository());

		[AllowAnonymous]
		public IViewComponentResult Invoke()
		{
            var usermail = User.Identity.Name;

            context c = new context();

            var writerID = c.writers.Where(x => x.writermail == usermail).Select(y => y.yazarID).FirstOrDefault();
            ViewBag.writerID1 = writerID;

            var values = wr.GetwrtierbyID(writerID);  //  BU VAR İLE OLŞTURDUĞUMUZ 
			

			return View(values);

		}




	}
}
