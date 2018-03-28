using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Macrosage.Face.Web.Controllers.tech
{
    /// <summary>
    /// 语音技术
    /// </summary>
    public class SpeechController : Controller
    {
        /// <summary>
        /// 语音识别
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// 语音合成
        /// </summary>
        /// <returns></returns>
        public ActionResult Tts()
        {
            return View();
        }

        /// <summary>
        /// 语音唤醒
        /// </summary>
        /// <returns></returns>
        public ActionResult Wake()
        {
            return View();
        }
    }
}