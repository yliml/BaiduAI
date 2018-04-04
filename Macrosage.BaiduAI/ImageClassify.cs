using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Macrosage.BaiduAI
{
    /// <summary>
    /// 图像识别
    /// </summary>
    public class ImageClassify
    {
        /// <summary>
        /// 植物识别
        /// </summary>
        /// <param name="filesrc"></param>
        public JObject PlantDetect(string filesrc)
        {
            var client = new Baidu.Aip.ImageClassify.ImageClassify(ApiConfig.APIKey, ApiConfig.SecretKey);
            var image = File.ReadAllBytes(filesrc);
            // 调用植物识别，可能会抛出网络等异常，请使用try/catch捕获
            var result = client.PlantDetect(image);
            return result;
        }
    }
}
