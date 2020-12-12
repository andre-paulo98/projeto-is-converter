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

        public override bool run(string data) {
            string exists = FileRead();
            string file = HTML(data, exists);

            try {
                File.WriteAllText(Path, file);
                return true;

            } catch (Exception e) {
                throw e;
            }
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
            text.Replace("<html><body>", string.Empty);
            text.Replace("</body></html>", string.Empty);
            return text;
        }

        private string HTML(dynamic data, string exists) {
            string html = BASE_HTML_INIT;

            html += exists;

            html += Decider(data);

            html += BASE_HTML_END;

            return html;
        }

        private string Decider(dynamic data) {
            string html = "";

            dynamic name = data.GetType().Name;
            dynamic fullName = data.GetType().FullName;

            if (isListOrExpando(data)) {

                if (name.Contains("ExpandoObject")) {
                    html += "<table border=1>";
                    foreach (var property in (IDictionary<String, Object>)data) {
                        html += Decider(property);
                    }
                    html += "</table>";
                } else if (name.Contains("List") && fullName.Contains("ExpandoObject")) {
                    foreach (var item in (List<ExpandoObject>)data) {
                        html += Decider(item);
                    }
                } else if (name.Contains("List")) {
                    foreach (var item in (List<Object>)data) {
                        html += "<td>" + Decider(item) + "</td>";
                    }
                } else {
                    throw new Exception("Error");
                }
            } else if (name.Contains("KeyValuePair")) {
                html += $"<tr><th>{data.Key}</th>";
                if (data.Value.GetType().Name.Contains("List")) {
                    html += Decider(data.Value);
                } else {
                    html += "<td>" + Decider(data.Value) + "</td>";
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