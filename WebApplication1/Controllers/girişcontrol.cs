using Microsoft.AspNetCore.Mvc;
using dataacseslayer.entityframwork;
using bussineslayer.contrete;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using entity.conti;
using dataacseslayer.concreat;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;

namespace WebApplication1.Controllers
{


    public class girişcontrol : Controller
    {
        [AllowAnonymous]
        public IActionResult Index()
        {
            return View();

        }
        [HttpPost]
        [AllowAnonymous]
        public async Task< IActionResult> Index(writer p)     // public async Task< IActionResult> unutma
		{
            context c = new context();

		 var datavalue = c.writers.FirstOrDefault(x => x.writermail == p.writermail && x.writerpassword == p.writerpassword);
          
            if (datavalue != null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name,p.writermail)
                };
                var useridentity= new ClaimsIdentity(claims,"a");
                ClaimsPrincipal principal = new ClaimsPrincipal(useridentity);

                await HttpContext.SignInAsync(principal);

                return RedirectToAction("Index", "Dashboard");

            }
            else
            {
                return View();
            }

		}
    }

}













//context c = new context();  //aşşağıda sorgu yaptık 

//var datavalue = c.writers.FirstOrDefault(x => x.writermail == p.writermail && x.writerpassword == p.writerpassword);
//if (datavalue != null)
//{
//	HttpContext.Session.SetString("userNAME", p.writermail);

//	return RedirectToAction("Index", "Writer");
//}
//else
//{
//	return View();

//}
