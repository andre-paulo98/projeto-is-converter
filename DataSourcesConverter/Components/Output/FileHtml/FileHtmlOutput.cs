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

        public void outputuhjkg(dynamic data)
        {
            string html = "";
            foreach (var property in (IDictionary<String, Object>)data)
            {

                html += "<tr>";

                html += $"<th>{property.Key}</th>";

                var type = property.Value.GetType();

                var value = "";
                if (type.Name.Contains("List"))
                { // List or Array
                    value = "<table border=1><tr>";

                    foreach (var item in (List<Object>)property.Value)
                    {

                        var typeValue = item.GetType();
                        var htmll = "";

                        if (typeValue.Name.Contains("ExpandoObject"))
                        {


                            htmll = "<table border=1>";

                            foreach (var property1 in (IDictionary<String, Object>)item)
                            {

                                htmll += $"<tr><th>{property1.Key}</th><td>{property1.Value}</td></tr>";

                            }

                            htmll += "</table>";

                        }
                        else
                        {
                            htmll = item + "";
                        }

                        value += $"<td>{htmll}</td>";

                    }

                    value += "</tr></table>";

                }
                else
                {
                    value = property.Value.ToString();
                }

                html += $"<td>{value}</td>";

                html += "</tr>";

            }

        }

        public void output(dynamic data)
        {
            string html = HTML(data);

            File.WriteAllText(@"C:\Users\NoMercy\Documents\test.html", html);
        }

        private string HTML(dynamic data)
        {
            string html = BASE_HTML_INIT;

            html += Decider(data);

            html += BASE_HTML_END;

            return html;
        }

        public override bool run(dynamic data) {
            return true;
        }

        private string Decider(dynamic data)
        {
            string html = "";

            dynamic name = data.GetType().Name;
            dynamic fullName = data.GetType().FullName;

            if (isListOrExpando(data))
            {
                
                if (name.Contains("ExpandoObject"))
                {
                    html += "<table border=1>";
                    foreach (var property in (IDictionary<String, Object>)data)
                    {
                        html += Decider(property);
                    }
                    html += "</table>";
                }
                else if (name.Contains("List") && fullName.Contains("ExpandoObject"))
                {
                    foreach (var item in (List<ExpandoObject>)data)
                    {
                        html += Decider(item);
                    }
                }
                else if (name.Contains("List"))
                {
                    foreach (var item in (List<Object>)data)
                    {
                        html += "<td>" + Decider(item) + "</td>";
                    }
                }
                else
                {
                    throw new Exception("Error");
                }
            }
            else if (name.Contains("KeyValuePair"))
            {
                html += $"<tr><th>{data.Key}</th>";
                if (data.Value.GetType().Name.Contains("List"))
                {
                    html += Decider(data.Value);
                }
                else
                {
                    html += "<td>" + Decider(data.Value) + "</td>";
                }
                

                html += "</tr>";
            }
            else if(data != null)
            {
                html += $"{data}";
            }
            
            return html;
        }

        private bool isListOrExpando(dynamic data)
        {
            dynamic name = data.GetType().Name;
            return (name.Contains("List") || name.Contains("ExpandoObject"));
        }
    }
}