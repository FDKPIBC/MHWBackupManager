using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using HtmlAgilityPack;

namespace MHWBackup.Utils
{
    public class HttpHelper
    {
        public static T Get<T>(string url)
        {
            var request = (HttpWebRequest)WebRequest.Create(url);
            var response = request.GetResponse() as HttpWebResponse;
            T t;
            if (response.StatusCode == HttpStatusCode.OK)
            {
                using (var reader = new StreamReader(response.GetResponseStream()))
                {
                    var json = reader.ReadToEnd();
                    t = JsonConvert.DeserializeObject<T>(json);
                }
            }
            else throw new Exception("请求失败,未获取到相应内容!");
            return t;
        }

        public static string GetString(string url)
        {
            var request = (HttpWebRequest)WebRequest.Create(url);
            var response = request.GetResponse() as HttpWebResponse;
            var result = string.Empty;
            if (response.StatusCode == HttpStatusCode.OK)
            {
                using (var reader = new StreamReader(response.GetResponseStream()))
                {
                    result = reader.ReadToEnd();
                }
            }
            else throw new Exception("请求失败,未获取到相应内容!");
            return result;
        }

        public static T Post<T>(string url,byte[] data)
        {
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "POST";
            var requestStream = request.GetRequestStream();
            requestStream.Write(data, 0, data.Length);
            var response = request.GetResponse() as HttpWebResponse;
            T t;
            if (response.StatusCode == HttpStatusCode.OK)
            {
                using (var reader = new StreamReader(response.GetResponseStream()))
                {
                    var json = reader.ReadToEnd();
                    t = JsonConvert.DeserializeObject<T>(json);
                }
            }
            else throw new Exception("请求失败,未获取到相应内容!");
            return t;
        }

        public static void DownloadImage(string url,string path)
        {
            WebClient wc = new WebClient();
            wc.DownloadFileAsync(new Uri(url), path);
        }

        public static void LoadHtml(string url)
        {
            var dom = new HtmlDocument();
            dom.LoadHtml(GetString(url));
            var Schedule = dom.DocumentNode.SelectSingleNode(@"/html[1]/body[1]/div[1]/div[1]/div[1]/section[1]/div[1]/div[2]");
        }
    }
}
