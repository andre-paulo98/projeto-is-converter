using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Dynamic;
using System.Net;
using System.IO;
using Newtonsoft.Json.Linq;

namespace DataSourcesConverter.Components.Inputs.APIRest {
    public class ApiRest : FlowInput {
        public string url { get; set; }
        public string method { get; set; }

        public override void run(ReceiveCallback callback) {
            string response = getResponse();
            callback(response);
        }

        public string getResponse() {
            string json = null;
            try {
                HttpWebRequest request = WebRequest.CreateHttp(url);
                request.Method = method;

                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                using (Stream responseStream = response.GetResponseStream())
                using (StreamReader myStreamReader = new StreamReader(responseStream, Encoding.UTF8)) {
                    json = myStreamReader.ReadToEnd();
                }
            } catch (Exception) {
                throw;
            }

            return json;
        }
    }
}
