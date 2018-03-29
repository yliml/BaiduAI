using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Macrosage.Model.Speech
{
    /// <summary>
    /// 语音合成类
    /// </summary>
    public class TtsModel
    {
        /// <summary>
        /// 合成的文本，使用UTF-8编码，请注意文本长度必须小于1024字节
        /// </summary>
        public string tex { get; set; }
        /// <summary>
        /// 语言选择,填写zh
        /// </summary>
        public string lang { get; set; } = "zh";
        /// <summary>
        /// 客户端类型选择，web端填写1
        /// </summary>
        public string ctp { get; set; } = "1";
        /// <summary>
        /// 用户唯一标识，用来区分用户，填写机器 MAC 地址或 IMEI 码，长度为60以内
        /// </summary>
        public string cuid { get; set; }
        /// <summary>
        /// 语速，取值0-9，默认为5中语速
        /// </summary>
        public int spd { get; set; }
        /// <summary>
        /// 音调，取值0-9，默认为5中语调
        /// </summary>
        public int pit { get; set; }
        /// <summary>
        /// 音量，取值0-15，默认为5中音量
        /// </summary>
        public int vol { get; set; }
        /// <summary>
        /// 发音人选择, 0为女声，1为男声，3为情感合成-度逍遥，4为情感合成-度丫丫，默认为普通女
        /// </summary>
        public int per { get; set; }
    }
}
