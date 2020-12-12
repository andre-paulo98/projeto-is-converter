using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace DataSourcesConverter.Components.Inputs.XmlFile {
    public class XmlFileInput : FlowInput {
        public string filePath { get; set; }
        XmlDocument dom;

        public XmlFileInput() {
            dom = new XmlDocument();
        }

        public override void run(ReceiveCallback callback) {
            string response = getResponse();
            callback(response);
        }

        public string getResponse() {
            try {
                XmlDocument doc = new XmlDocument();
                doc.Load(filePath);
                return JsonConvert.SerializeXmlNode(doc.DocumentElement,Newtonsoft.Json.Formatting.Indented).Replace("@","");
            } catch (Exception) {
                throw;
            }
        }
    }
}
