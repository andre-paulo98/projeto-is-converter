using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSourcesConverter.Components.Output.FileHtmlOutput {
    class FileHtml {

        public void output(dynamic data) {

            string html = "<html><body><table border=1>";

            foreach (var property in (IDictionary<String, Object>) data) {


                Console.WriteLine(property.Key + ": " + property.Value);
                html += "<tr>";

                html += $"<th>{property.Key}</th>";

                var type = property.Value.GetType();

                var value = "";
                if(type.Name.Contains("List")) { // List or Array
                    value = "<table border=1><tr>";

                    foreach (var item in (List<Object>)property.Value) {



                        var typeValue = item.GetType();
                        var htmll = "";


                        if(typeValue.Name.Contains("ExpandoObject")) {


                            htmll = "<table border=1>";

                            foreach (var property1 in (IDictionary<String, Object>)item) {

                                htmll += $"<tr><th>{property1.Key}</th><td>{property1.Value}</td></tr>";

                            }



                            htmll += "</table>";



                        } else {
                            htmll = item + "";
                        }

                        value += $"<td>{htmll}</td>";


                    }

                    value += "</tr></table>";

                } else {
                    value = property.Value.ToString();
                }

                html += $"<td>{value}</td>";

                html += "</tr>";

            }


            html += "</table></body></html>";

            File.WriteAllText(@"C:\Users\andre\Desktop\test.html", html);


        }
    }
}
