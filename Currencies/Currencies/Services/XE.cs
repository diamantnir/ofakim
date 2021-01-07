using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Currencies.Services
{
    
    public class XE : IVendor
    {
        private const string endPoint = "https://xecdapi.xe.com/v1/convert_from.json/?from=CUR1&to=CUR2";
        private const string id = "gyngynv4553411092";
        private const string key = "j29j7ntm8hjvuspgps407i6kkc";

        public string from { get; set; }
        public string to { get; set; }

        public async Task<string> GetData()
        {
            string url = endPoint.Replace("CUR1", from).Replace("CUR2", to);
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Headers.Add("Account ID", "gyngynv4553411092");
            request.Headers.Add("Account API Key", "j29j7ntm8hjvuspgps407i6kkc");

            using (HttpWebResponse response = (HttpWebResponse)await request.GetResponseAsync())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                return await reader.ReadToEndAsync();
            }
        }

}
}
