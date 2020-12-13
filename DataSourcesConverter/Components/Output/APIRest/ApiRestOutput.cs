using DataSourcesConverter.Utils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DataSourcesConverter.Components.Output.APIRest
{
    public class ApiRestOutput : FlowOutput{
        public string Url { get; set; }
        public string Method { get; set; }

        public ApiRestOutput() {
            Type = OutputType.ApiRestOutput;
        }

        public override bool run(string data)
        {
            Logger.Instance.info(Type.ToString(), "Pedido HTTP");
            HttpStatusCode code;

            bool status = false;
            try
            {
                Logger.Instance.status(Type.ToString(), "A configurar o pedido HTTP...");
                HttpWebRequest request = WebRequest.CreateHttp(Url);
                request.Method = Method;
                Logger.Instance.status(Type.ToString(), "A executar o pedido HTTP...");
                byte[] byteArray = Encoding.UTF8.GetBytes(data);
                request.ContentLength = byteArray.Length;
                request.ContentType = "application/x-www-form-urlencoded";

                using(Stream dataStream = request.GetRequestStream())
                {
                    dataStream.Write(byteArray, 0, byteArray.Length);
                    using(WebResponse response = request.GetResponse())
                    {
                        code = ((HttpWebResponse)response).StatusCode;
                        if (code == HttpStatusCode.OK || code == HttpStatusCode.Accepted || code == HttpStatusCode.Created) {
                            
                            status = true;
                        }                            
                    }
                }
            }
            catch (Exception e)
            {
                Logger.Instance.error(Type.ToString(), "Erro a efetuar o pedido: ");
                Logger.Instance.status(Type.ToString(), e.Message);
            }
            Logger.Instance.success(Type.ToString(), "Pedido HTTP -- Concluido");
            return status;
        }
    }
}
