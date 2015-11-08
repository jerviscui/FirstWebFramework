using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using System.Xml.Serialization;
using Data;
using Newtonsoft.Json;

namespace FirstWebFramework.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Entity entity = new Entity()
            {
                Id = 1,
                Name = "test",
                Sex = "guess"
            };

            string json = JsonConvert.SerializeObject(entity);
            var obj = JsonConvert.DeserializeObject<Entity>(json);


            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}