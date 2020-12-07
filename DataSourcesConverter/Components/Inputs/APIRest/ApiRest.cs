using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Dynamic;
using System.Net;
using System.IO;
using Newtonsoft.Json.Linq;

namespace DataSourcesConverter.Components.Inputs {
    public class ApiRest : FlowInput {
        public string url { get; set; }

        public override dynamic run() {
            JToken json = makeRequest(url);

            var converter = new ExpandoObjectConverter();

            dynamic output;

            if (json.Type == JTokenType.Array) {
                output = JsonConvert.DeserializeObject<List<ExpandoObject>>(json.ToString());
            } else if (json.Type == JTokenType.Object) {
                output = JsonConvert.DeserializeObject<ExpandoObject>(json.ToString());
            } else {
                throw new NotSupportedException("Json output not suported!!");
            }

            return output;
        }



        public static JToken makeRequest(string uri) {
            JToken json = null;
            try {
                HttpWebRequest request = WebRequest.CreateHttp(uri);
                request.Method = "GET";

                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                using (Stream responseStream = response.GetResponseStream())
                using (StreamReader myStreamReader = new StreamReader(responseStream, Encoding.UTF8)) {
                    string responseJSON = myStreamReader.ReadToEnd();
                    json = JToken.Parse(responseJSON);
                }


            } catch (Exception) {
                throw;
            }

            return json;
        }
    }
}
