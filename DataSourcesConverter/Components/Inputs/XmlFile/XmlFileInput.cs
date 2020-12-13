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
            Logger.Instance.info(Name, "Ler ficheiro xml");
            XmlNode data = readFile(true);
            if(data != null){
                Logger.Instance.status(Name, "A processar ficheiro...");
                string output = JsonConvert.SerializeXmlNode(data, Newtonsoft.Json.Formatting.Indented).Replace("@", "");
                Logger.Instance.success(Name, "Ler ficheiro xml -- Concluido");
                callback(output);
            }else {
                Logger.Instance.error(Name, "Ler ficheiro xml -- Falhou");
            }
        }

        public XmlNode readFile(bool log = false) {
            try {
                if(log)
                Logger.Instance.status(Name, "A abrir ficheiro...");
                XmlDocument doc = new XmlDocument();
                if (log)
                    Logger.Instance.status(Name, "A ler ficheiro...");
                doc.Load(path);
                return doc.DocumentElement;
            } catch (Exception e) {
                if (log) {
                    Logger.Instance.error(Name, "Erro a ler o ficheiro: ");
                    Logger.Instance.status(Name, e.Message);
                } else {
                    throw e;
                }
            }
            return null;
        }
    }
}
