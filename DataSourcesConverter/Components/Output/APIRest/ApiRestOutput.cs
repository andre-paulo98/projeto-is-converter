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
        public string url { get; set; }
        public string method { get; set; }

        public override bool run(string data)
        {
            HttpStatusCode code;
            try
            {
                HttpWebRequest request = WebRequest.CreateHttp(url);
                request.Method = method;
                byte[] byteArray = Encoding.UTF8.GetBytes(data);
                request.ContentLength = byteArray.Length;
                request.ContentType = "application/x-www-form-urlencoded";

                using(Stream dataStream = request.GetRequestStream())
                {
                    dataStream.Write(byteArray, 0, byteArray.Length);
                    using(WebResponse response = request.GetResponse())
                    {
                        code = ((HttpWebResponse)response).StatusCode;
                        if (code == HttpStatusCode.OK || code == HttpStatusCode.Accepted || code == HttpStatusCode.Created)
                            return true;
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return false;
        }
    }
}
