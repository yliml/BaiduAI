using Macrosage.Model.ImageClassify;
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

        private static readonly Baidu.Aip.ImageClassify.ImageClassify client = new Baidu.Aip.ImageClassify.ImageClassify(ApiConfig.APIKey, ApiConfig.SecretKey);
        /// <summary>
        /// 植物识别
        /// </summary>
        /// <param name="filesrc"></param>
        public PlantModel PlantDetect(string filesrc)
        {
            var image = File.ReadAllBytes(filesrc);
            var result = client.PlantDetect(image);
            return GetPlant(result);
        }

        /// <summary>
        /// 车辆识别
        /// </summary>
        /// <param name="filesrc"></param>
        /// <returns></returns>
        public PlantModel CarDetect(string filesrc)
        {
            var image = File.ReadAllBytes(filesrc);
            var result = client.CarDetect(image);
            return GetPlant(result);
        }
        /// <summary>
        /// 动物识别
        /// </summary>
        /// <param name="filesrc"></param>
        /// <returns></returns>
        public PlantModel AnimalDetect(string filesrc)
        {
            var image = File.ReadAllBytes(filesrc);
            var result = client.AnimalDetect(image);
            return GetPlant(result);
        }

        private PlantModel GetPlant(JObject jObject)
        {
            PlantModel model = new PlantModel();

            try
            {
                model = jObject.ToObject<PlantModel>();
            }
            catch (Exception)
            {
               PlantModel1 model1 = jObject.ToObject<PlantModel1>();
                model.log_id = model1.log_id;
                model.result = new List<PlantData> {
                    model1.result
                };
            }
            return model;
        }
    }
}
