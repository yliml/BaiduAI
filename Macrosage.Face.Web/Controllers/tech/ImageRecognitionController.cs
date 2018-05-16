using Macrosage.BaiduAI;
using Macrosage.Weixin;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Macrosage.Face.Web.Controllers.tech
{
    /// <summary>
    /// 图像识别
    /// </summary>
    public class ImageRecognitionController : Controller
    {
        private readonly static ImageClassify imageClassify = new ImageClassify();
        /// <summary>
        /// 
        /// </summary>
        /// <param name="type">1:植物识别2:动物识别3:车型识别</param>
        /// <returns></returns>
        public ActionResult Index(int type = 1)
        {
            ViewData["type"] = type;
            return View();
        }

        /// <summary>
        /// 植物识别
        /// </summary>
        /// <param name="serverId"></param>
        /// <returns></returns>
        public JsonResult PlantDetect(string serverId = "")
        {
            string filename = System.Web.HttpContext.Current.Server.MapPath("/Static/img/demoplant.jpg");
            if (!string.IsNullOrWhiteSpace(serverId))
            {
                filename = Getfilename(serverId);
            }
            var data = imageClassify.PlantDetect(filename);
            return Json(data, JsonRequestBehavior.AllowGet);
        }

        public JsonResult AnimalDetect(string serverId = "")
        {
            string filename = System.Web.HttpContext.Current.Server.MapPath("/Static/img/demoanimal.jpg");
            if (!string.IsNullOrWhiteSpace(serverId))
            {
                filename = Getfilename(serverId);
            }
            var data = imageClassify.AnimalDetect(filename);
            return Json(data, JsonRequestBehavior.AllowGet);
        }

        public JsonResult CarDetect(string serverId = "")
        {
            string filename = System.Web.HttpContext.Current.Server.MapPath("/Static/img/democar.jpg");
            if (!string.IsNullOrWhiteSpace(serverId))
            {
                filename = Getfilename(serverId);
            }
            var data = imageClassify.CarDetect(filename);
            return Json(data, JsonRequestBehavior.AllowGet);
        }

        private string Getfilename(string serverId)
        {
            string filename = System.Web.HttpContext.Current.Server.MapPath("/upload/img/");
            if (!System.IO.Directory.Exists(filename))
                System.IO.Directory.CreateDirectory(filename);

            string date = DateTime.Now.ToString("yyyy-MM-dd");
            filename += date + "/";

            if (!System.IO.Directory.Exists(filename))
                System.IO.Directory.CreateDirectory(filename);

            string guid = Guid.NewGuid().ToString();
            filename += $"/{guid}.jpg";

            WeixinUtility.GetVoice(serverId, filename);
            return filename;
        }
    }
}