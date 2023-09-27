using BlogApidemo.dataAccsesslayer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace BlogApidemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DefaultController : ControllerBase
    {
        [HttpGet]
        public IActionResult çalışanlist()
        {

            using var c = new context();
            var values =c.çalışans.ToList();

            return Ok(values);
        }
        ///////
        [HttpPost]
        public IActionResult çalışanekle(çalışan çalışan) {

            using var c = new context();
            c.Add(çalışan);
            c.SaveChanges();

            return Ok();
        }
        ////////
        [HttpGet("{id}")]
        public IActionResult çalışangetir(int id)
        {
            using var c = new context();
            var çalışan=c.çalışans.Find(id);
            if (çalışan==null)
            {
                return NotFound();
            }
            else
            {
                return Ok(çalışan);
            }
           

        }
        //////
        [HttpDelete("{id}")]
        public IActionResult çalışansil(int id)
        {
            using var c = new context();
            var çalışan = c.çalışans.Find(id);
            if (çalışan== null)
            {
                return NotFound();
            }
            else
            {
                c.Remove(çalışan);
                c.SaveChanges();
                return Ok();
            }

        }
        //
        [HttpPut]
        public IActionResult çalışangüncelle(çalışan çalışans)
        {
            using var c =new context();
            var çal = c.Find<çalışan>(çalışans.ID);

            if (çal==null)
            {
                return NotFound();

            }
            else
            {
                çal.Name = çalışans.Name;
                c.Update(çal);
                c.SaveChanges();
                return Ok();
            }

         
           

        }

    }
}
