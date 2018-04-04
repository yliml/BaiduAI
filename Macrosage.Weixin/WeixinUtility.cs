using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;
using Senparc.Weixin.MP.Containers;

namespace Macrosage.Weixin
{
    public class WeixinUtility
    {
        /// <summary>
        /// 下载多媒体文件
        /// </summary>
        /// <param name="mediaId"></param>
        /// <param name="filesrc"></param>
        public static void GetVoice(string mediaId, string filesrc)
        {
            var accessToken = AccessTokenContainer.TryGetAccessToken(ApiConfig.AppID, ApiConfig.AppSecret);

            MemoryStream ms = new MemoryStream();
            Senparc.Weixin.MP.AdvancedAPIs.MediaApi.Get(accessToken, mediaId, ms);
            ms.Seek(0, SeekOrigin.Begin);

            File.WriteAllBytes(filesrc, ms.GetBuffer());
        }
    }
}
