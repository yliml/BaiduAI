using Macrosage.Model.Speech;
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
    }
}
