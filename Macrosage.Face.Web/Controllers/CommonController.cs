using Macrosage.Weixin;
using Senparc.Weixin.MP.Helpers;
using System.IO;
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
            string timestamp = JSSDKHelper.GetTimestamp();
            string nonceStr = JSSDKHelper.GetNoncestr();

            string ticket = Senparc.Weixin.MP.Containers.JsApiTicketContainer.TryGetJsApiTicket(ApiConfig.AppID, ApiConfig.AppSecret);
            string signature = JSSDKHelper.GetSignature(ticket, nonceStr, timestamp, url);
            
            return Json(new { appId = ApiConfig.AppID, timestamp, nonceStr, signature }, JsonRequestBehavior.AllowGet);
        }
    }
}