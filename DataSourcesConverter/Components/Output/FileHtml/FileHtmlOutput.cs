using DataSourcesConverter.Utils;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSourcesConverter.Components.Output.FileHtml {
    public class FileHtmlOutput : FlowOutput {

        private const string BASE_HTML_INIT = "<html><body>";
        private const string BASE_HTML_END = "</body></html>";

        public string Path { get; set; }
        public bool Overwrite { get; set; }

        public FileHtmlOutput() {
            Type = OutputType.HtmlFileOutput;
        }

        public override bool run(string data) {
            Logger.Instance.info(Name, "Escrita para ficheiro HTML");
            Logger.Instance.status(Name, "A ler o ficheiro ...");
            string exists = FileRead();

            Logger.Instance.status(Name, "A obter os dados ...");
            JToken json = JToken.Parse(data);

            dynamic output;
            if (json.Type == JTokenType.Array) {
                output = JsonConvert.DeserializeObject<List<ExpandoObject>>(json.ToString());
            } else if (json.Type == JTokenType.Object) {
                output = JsonConvert.DeserializeObject<ExpandoObject>(json.ToString());
            } else {
                throw new NotSupportedException("Json output not suported!!");
            }

            Logger.Instance.status(Name, "A converter os dados ...");
            string file = HTML(output, exists);

            Logger.Instance.status(Name, "A escrever os dados para o ficheiro...");
            try {
                File.WriteAllText(Path, file);
            } catch (Exception e) {
                Logger.Instance.error(Name, "Erro a escrever para ficheiro HTML: ");
                Logger.Instance.status(Name, e.Message);
                Logger.Instance.error(Name, "Escrita para ficheiro HTML -- Falhou");
                return false;
            }
            Logger.Instance.success(Name, "Escrita para ficheiro HTML -- Concluido");
            return true;
        }

        private string FileRead() {
            string read = null;

            if (!Overwrite && File.Exists(Path)) {
                read += ReadFile();
            }
            return read;
        }

        private string ReadFile() {
            string text = System.IO.File.ReadAllText(Path);
            text = text.Replace("<html><body>", string.Empty).Replace("</body></html>", string.Empty);
            return text;
        }

        private string HTML(dynamic data, string exists) {
            string html = BASE_HTML_INIT;

            html += exists;

            html += Decider(data, true);

            html += BASE_HTML_END;

            return html;
        }

        private string Decider(dynamic data, bool isFirst) {
            string html = "";

            dynamic name = data.GetType().Name;
            dynamic fullName = data.GetType().FullName;

            if (isListOrExpando(data)) {

                if (name.Contains("ExpandoObject")) {
                    html += "<table border=1>";
                    foreach (var property in (IDictionary<String, Object>)data) {
                        html += Decider(property, false);
                    }
                    html += "</table>";
                } else if (name.Contains("List") && fullName.Contains("ExpandoObject")) {
                    if(isFirst)
                        html += "<table border=1><td>";
                    foreach (var item in (List<ExpandoObject>)data) {
                        html += Decider(item,false);
                    }
                    if (isFirst)
                        html += "</td></table>";
                } else if (name.Contains("List")) {
                    if (isFirst)
                        html += "<table border=1><td>";
                    foreach (var item in (List<Object>)data) {
                        html += "<td>" + Decider(item, false) + "</td>";
                    }
                    if (isFirst)
                        html += "</td></table>";
                } else {
                    throw new Exception("Error");
                }
            } else if (name.Contains("KeyValuePair")) {
                html += $"<tr><th>{data.Key}</th>";
                if (data.Value.GetType().Name.Contains("List")) {
                    html += Decider(data.Value, false);
                } else {
                    html += "<td>" + Decider(data.Value, false) + "</td>";
                }


                html += "</tr>";
            } else if (data != null) {
                html += $"{data}";
            }

            return html;
        }

        private bool isListOrExpando(dynamic data) {
            dynamic name = data.GetType().Name;
            return (name.Contains("List") || name.Contains("ExpandoObject"));
        }
    }
}