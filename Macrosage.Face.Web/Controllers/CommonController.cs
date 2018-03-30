using Macrosage.Weixin;
using Senparc.Weixin.Exceptions;
using Senparc.Weixin.MP.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Macrosage.Face.Web.Controllers
{
    public class CommonController : Controller
    {
        // GET: Common
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetJsApi(string url)
        {
            //RegisterToken();
            //RegisterTicket();
            ////获取access_token
            //string token = AccessTokenContainer.GetAccessToken(ApiConfig.AppID);
            ////获得jsapi_ticket
            //string ticket = JsApiTicketContainer.GetJsApiTicket(ApiConfig.AppID);

            //System.DateTime startTime = TimeZone.CurrentTimeZone.ToLocalTime(new System.DateTime(1970, 1, 1));
            ////时间戳
            //long timestamp = (long)(DateTime.Now - startTime).TotalSeconds;
            ////随机字符
            //string noncestr = WeixinUtility.RandCodeCard(16);

            //string signature = WeixinUtility.GetSignature(ticket, noncestr, timestamp.ToString(), url);


            string ticket = string.Empty;
            string signature = string.Empty;
            string timestamp = JSSDKHelper.GetTimestamp();
            string nonceStr = JSSDKHelper.GetNoncestr();
            //try
            //{
                ticket = Senparc.Weixin.MP.Containers.JsApiTicketContainer.TryGetJsApiTicket(Macrosage.Weixin.ApiConfig.AppID, Macrosage.Weixin.ApiConfig.AppSecret);
                //signature = JSSDKHelper.GetSignature(ticket, nonceStr, timestamp, Request.Url.AbsoluteUri.ToString());
                signature = JSSDKHelper.GetSignature(ticket, nonceStr, timestamp, url);

            //}
            //catch (ErrorJsonResultException ex)
            //{
            //    return Json(new { }, JsonRequestBehavior.AllowGet);
            //}
            return Json(new { appId = ApiConfig.AppID, timestamp, nonceStr, signature }, JsonRequestBehavior.AllowGet);
        }

    }
}