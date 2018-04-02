using Macrosage.BaiduAI;
using Macrosage.Model.Speech;
using Macrosage.Weixin;
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
        private static readonly BaiduSpeech bs = new BaiduSpeech();
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
        [HttpGet]
        public ActionResult Tts()
        {
            return View();
        }

        /// <summary>
        /// 语音合成
        /// </summary>
        /// <param name="res"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult Tts(TtsModel res)
        {
            string filename = System.Web.HttpContext.Current.Server.MapPath("/upload/tts/");
            if (!System.IO.Directory.Exists(filename))
                System.IO.Directory.CreateDirectory(filename);

            string date = DateTime.Now.ToString("yyyy-MM-dd");
            filename += date + "/";

            if (!System.IO.Directory.Exists(filename))
                System.IO.Directory.CreateDirectory(filename);

            string guid = Guid.NewGuid().ToString();
            filename += $"/{guid}.mp3";
            var f = bs.Tts(res, filename);
            string name = $"/upload/tts/{date}/{guid}.mp3";
            return Json(new { IsSuccess = f, Result = f ? name : string.Empty });
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