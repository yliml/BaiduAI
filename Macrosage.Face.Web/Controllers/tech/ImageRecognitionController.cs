using Macrosage.BaiduAI;
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
        // GET: ImageRecognition
        public ActionResult Index()
        {
            return View();
        }
    }
}