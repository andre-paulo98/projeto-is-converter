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
    public class ApiRestInput : FlowInput {
        public string url { get; set; }
        public string method { get; set; }

        public ApiRestInput() {
            Type = InputType.ApiRestInput;
        }

        public override void run(ReceiveCallback callback) {
            Logger.Instance.info(Type.ToString(), "Pedido HTTP");
            string response = getResponse(true);
            callback(response);
            Logger.Instance.info(Type.ToString(), "Pedido HTTP -- Concluido");
        }

        public string getResponse(bool log = false) {
            string json = null;
            try {
                if (log)
                    Logger.Instance.status(Type.ToString(), "A configurar o pedido HTTP...");
                
                HttpWebRequest request = WebRequest.CreateHttp(url);
                request.Method = method;

                if (log)
                    Logger.Instance.status(Type.ToString(), "A executar o pedido HTTP...");
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                using (Stream responseStream = response.GetResponseStream())
                using (StreamReader myStreamReader = new StreamReader(responseStream, Encoding.UTF8)) {
                    json = myStreamReader.ReadToEnd();
                }
            } catch (Exception e) {
                Logger.Instance.error(Type.ToString(), "Erro a efetuar o pedido: ");
                Logger.Instance.status(Type.ToString(), e.Message);
            }

            return json;
        }
    }
}
