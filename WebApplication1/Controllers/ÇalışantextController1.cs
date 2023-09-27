using DocumentFormat.OpenXml.Office2010.ExcelAc;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http;
using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;

namespace WebApplication1.Controllers
{
    public class ÇalışantextController1 : Controller
    {
        [AllowAnonymous]
        public async Task<IActionResult> Index()  // ssl sertifası olamdığı için çalışmadı 
        {
            var htppClient= new HttpClient();
            var responsemessage = await htppClient.GetAsync("https://localhost:7189/api/Default");
            var jsonString =await responsemessage.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<List<Class1>>(jsonString);  //   Class1 aşşağıda açtım 

            return View();
        }
    }
    public class Class1 {
       
        public int ID { get; set; }

        public string Name { get; set; }


    }
}
