using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.ViewComponents
{
	public class CommentList1 :ViewComponent
	{

		public IViewComponentResult Invoke()
		{

			var commentvaluse = new List<UserComment>()
			{
				new UserComment()
				{
					ID = 1,
					username="yusuf",
				 },

				new UserComment()
				{
					ID = 2,
					username="Mert",
				 },
				new UserComment()
				{
					ID = 3,
					username="Merve",
				 }




	};

			return View(commentvaluse);
		}

	

	}
}
