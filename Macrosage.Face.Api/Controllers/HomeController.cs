using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Macrosage.Face.Api.Controllers
{
    public class HomeController : Controller
    {
        private static readonly BaiduFace client = new BaiduFace();
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }
        /// <summary>
        /// 检测人脸
        /// </summary>
        /// <param name="file"></param>
        /// <returns></returns>
        public JsonResult FaceCheck(string file)
        {
            var result = client.FaceCheck(file);
            return Json(result);
        }
    }
}
