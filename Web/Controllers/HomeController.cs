using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using System.Xml.Serialization;
using Data;
using Web.Extension;
using Newtonsoft.Json;
using WebService;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IEntityService _entityService;

        /// <summary>
        /// 初始化 <see cref="T:System.Web.Mvc.Controller"/> 类的新实例。
        /// </summary>
        public HomeController(IEntityService entityService)
        {
            _entityService = entityService;
        }

        public ActionResult Index()
        {
            Entity entity = _entityService.GetEntity();

            string json = JsonConvert.SerializeObject(entity);
            var obj = JsonConvert.DeserializeObject<Entity>(json);

            var model = entity.ToModel();

            return View(model);
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