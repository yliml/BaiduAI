using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;
using Senparc.Weixin.MP.Containers;

namespace Macrosage.Weixin
{
    public class WeixinUtility
    {
        #region 生成JS-SDK权限验证的签名
        public static string GetSignature(string jsapi_ticket, string noncestr, string timestamp, string url)
        {

            string tmpStr = "jsapi_ticket=" + jsapi_ticket + "&noncestr=" + noncestr + "&timestamp=" + timestamp + "&url=" + url;

            return FormsAuthentication.HashPasswordForStoringInConfigFile(tmpStr, "SHA1");

        }
        #endregion

        #region 随机字符串
        public static string RandCodeCard(int n)
        {
            //,a,b,c,d,e,f,g,h,i,j,k,m,n,o,p,q,r,s,t,u,v,w,x,y,z
            string strchar = "0,A,1,B,2,C,3,D,4,E,5,F,6,J,K,7,T,U,V,8,Y,Z,9,G,H,I,L,M,N,O,P,Q,R,S,W,X";
            string[] VcArray = strchar.Split(',');
            string VNum = "";//由于字符串很短，就不用StringBuilder了 
            int temp = -1; //记录上次随机数值，尽量避免产生几个一样的随机数
            //采用一个简单的算法以保证生成随机数的不同 
            Random rand = new Random();
            for (int i = 1; i < n + 1; i++)
            {
                if (temp != -1)
                {
                    rand = new Random(GetRandomSeed());
                }
                int t = rand.Next(26);
                if (temp != -1 && temp == t)
                {
                    return RandCode(n);
                }
                temp = t;
                VNum += VcArray[t];
            }
            return VNum;//返回生成的随机数 
        }
        public static int GetRandomSeed()
        {
            byte[] bytes = new byte[4];
            System.Security.Cryptography.RNGCryptoServiceProvider rng = new System.Security.Cryptography.RNGCryptoServiceProvider();
            rng.GetBytes(bytes);
            return BitConverter.ToInt32(bytes, 0);
        }
        /// <summary>
        /// 数字和字母随机数
        /// </summary>
        /// <param name="n">生成长度</param>
        /// <returns></returns>
        public static string RandCode(int n)
        {
            //,a,b,c,d,e,f,g,h,i,j,k,m,n,o,p,q,r,s,t,u,v,w,x,y,z
            string strchar = "0,1,2,3,4,5,6,7,8,9";
            string[] VcArray = strchar.Split(',');
            string VNum = "";//由于字符串很短，就不用StringBuilder了 
            int temp = -1; //记录上次随机数值，尽量避免产生几个一样的随机数
            //采用一个简单的算法以保证生成随机数的不同 
            Random rand = new Random();
            for (int i = 1; i < n + 1; i++)
            {
                if (temp != -1)
                {
                    rand = new Random(GetRandomSeed());
                }
                int t = rand.Next(10);
                if (temp != -1 && temp == t)
                {
                    return RandCode(n);
                }
                temp = t;
                VNum += VcArray[t];
            }
            return VNum;//返回生成的随机数 
        } 
        #endregion
    }
}
