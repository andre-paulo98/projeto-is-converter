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
            XmlNode data = readFile(true);
            if(data != null){
                Logger.Instance.status(Type.ToString(), "A processar ficheiro...");
                string output = JsonConvert.SerializeXmlNode(data, Newtonsoft.Json.Formatting.Indented).Replace("@", "");
                Logger.Instance.success(Type.ToString(), "Ler ficheiro xml -- Concluido");
                callback(output);
            }else {
                Logger.Instance.error(Type.ToString(), "Ler ficheiro xml -- Falhou");
            }
        }

        public XmlNode readFile(bool log = false) {
            try {
                if(log)
                Logger.Instance.status(Type.ToString(), "A abrir ficheiro...");
                XmlDocument doc = new XmlDocument();
                if (log)
                    Logger.Instance.status(Type.ToString(), "A ler ficheiro...");
                doc.Load(path);
                return doc.DocumentElement;
            } catch (Exception e) {
                if (log) {
                    Logger.Instance.error(Type.ToString(), "Erro a ler o ficheiro: ");
                    Logger.Instance.status(Type.ToString(), e.Message);
                } else {
                    throw e;
                }
            }
            return null;
        }
    }
}
