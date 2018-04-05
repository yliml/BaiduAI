using Macrosage.Model.Speech;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Macrosage.BaiduAI
{
    /*
     * 百度语音识别api接口请求
     * 文档地址：http://ai.baidu.com/docs#/ASR-API/top
     */
    public class BaiduSpeech
    {
        /// <summary>
        /// 语音合成
        /// </summary>
        /// <param name="model"></param>
        /// <param name="filesrc"></param>
        /// <returns></returns>
        public bool Tts(TtsModel model, string filesrc)
        {
            var _ttsClient = new Baidu.Aip.Speech.Tts(ApiConfig.APIKey, ApiConfig.SecretKey);
            // 可选参数
            var option = new Dictionary<string, object>()
            {
                {"spd", model.spd}, // 语速
                {"vol", model.vol}, // 音量
                {"per", model.per}, // 发音人，4：情感度丫丫童声
                {"pit", model.pit}  // 音调
            };
            var result = _ttsClient.Synthesis(model.tex, option);

            if (result.ErrorCode == 0)  // 或 result.Success
            {
                File.WriteAllBytes(filesrc, result.Data);
                return true;
            }
            return false;
        }
        // 识别本地文件
        public JObject AsrData(string filesrc)
        {
            var _asrClient = new Baidu.Aip.Speech.Asr(ApiConfig.APIKey, ApiConfig.SecretKey);
            var data = File.ReadAllBytes(filesrc);
            var result = _asrClient.Recognize(data, "pcm", 16000);
            return result;
        }

        // 识别URL中的语音文件
        public void AsrUrl()
        {
            var _asrClient = new Baidu.Aip.Speech.Asr(ApiConfig.APIKey, ApiConfig.SecretKey);
            var result = _asrClient.Recognize(
                "http://xxx.com/待识别的pcm文件地址",
                "http://xxx.com/识别结果回调地址",
                "amr",
                16000);
            Console.WriteLine(result);
        }
    }
}
