using DataSourcesConverter.Utils;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace DataSourcesConverter.Components.Inputs.XmlFile {
    public class XmlFileInput : FlowInput {
        public string path { get; set; }
        XmlDocument dom;

        public XmlFileInput() {
            Type = InputType.XmlFileInput;
            dom = new XmlDocument();
        }

        public override void run(ReceiveCallback callback) {
            Logger.Instance.info(Type.ToString(), "Ler ficheiro xml");
            string response = getResponse();
            callback(response);
            Logger.Instance.success(Type.ToString(), "Ler ficheiro xml -- Concluido");
        }

        public string getResponse() {
            try {
                Logger.Instance.status(Type.ToString(), "A abrir ficheiro...");
                XmlDocument doc = new XmlDocument();
                doc.Load(path);
                Logger.Instance.status(Type.ToString(), "A processar ficheir...");
                return JsonConvert.SerializeXmlNode(doc.DocumentElement,Newtonsoft.Json.Formatting.Indented).Replace("@","");
            } catch (Exception e) {
                Logger.Instance.error(Type.ToString(), "Erro a ler o ficheiro: ");
                Logger.Instance.status(Type.ToString(), e.Message);
            }
            return "";
        }
    }
}
