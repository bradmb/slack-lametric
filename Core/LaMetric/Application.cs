using System.Configuration;
using System.IO;
using System.Net;

namespace Core.LaMetric
{
    public class Application
    {
        /// <summary>
        /// Sends a LaMetric packet to their servers and displays it on a LaMetric Time
        /// </summary>
        /// <param name="model"></param>
        public void SendMessage(string message)
        {
            var model = new Models.LaMetric();
            model.frames = new[]
            {
                new Models.Frame()
                {
                    index = 0,
                    icon = "i1037",
                    text = message
                }
            };

            this.SendMessage(model);
        }

        /// <summary>
        /// Sends a LaMetric packet to their servers and displays it on a LaMetric Time
        /// </summary>
        /// <param name="model"></param>
        public void SendMessage(Models.LaMetric model)
        {
            var json = Newtonsoft.Json.JsonConvert.SerializeObject(model);

            var webRequest = (HttpWebRequest)WebRequest.Create(ConfigurationManager.AppSettings["lametric:url"]);
            webRequest.Method = "POST";
            webRequest.Accept = "application/json";
            webRequest.Headers.Add("X-Access-Token", ConfigurationManager.AppSettings["lametric:token"]);

            using (var stream = new StreamWriter(webRequest.GetRequestStream()))
            {
                stream.Write(json);
                stream.Flush();
                stream.Close();
            }

            webRequest.GetResponse();
        }
    }
}