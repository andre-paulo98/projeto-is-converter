using DataSourcesConverter.Components;
using DataSourcesConverter.Components.Inputs;
using DataSourcesConverter.Components.Inputs.APIRest;
using DataSourcesConverter.Components.Inputs.Broker;
using DataSourcesConverter.Components.Inputs.XmlFile;
using DataSourcesConverter.Components.Output;
using DataSourcesConverter.Components.Output.APIRest;
using DataSourcesConverter.Components.Output.FileHtml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace DataSourcesConverter.Utils {
    class XmlManager {

        public List<Flow> ImportXML(string path) {

            XmlDocument doc = new XmlDocument();
            doc.Load(path);

            List<Flow> flows = new List<Flow>();

            XmlNodeList nodes = doc.SelectNodes($"/Flows/Flow");

            foreach (XmlNode item in nodes) {

                Flow flow = new Flow();
                XmlNode nodeInput = item.SelectSingleNode("Input");
                InputType inputType = (InputType)Enum.Parse(typeof(InputType), nodeInput.Attributes["Type"].Value);

                if (inputType.ToString() == InputType.ApiRestInput.ToString()) {
                    ApiRestInput input = new ApiRestInput() {
                        Name = nodeInput["Name"].InnerText,
                        Url = nodeInput["Url"].InnerText,
                        Method = nodeInput["Method"].InnerText
                    };
                    flow.Input = input;
                } else if (inputType.ToString() == InputType.XmlFileInput.ToString()) {
                    XmlFileInput input = new XmlFileInput() {
                        Name = nodeInput["Name"].InnerText,
                        Path = nodeInput["Path"].InnerText
                    };
                    flow.Input = input;
                } else if (inputType.ToString() == InputType.BrokerInput.ToString()) {
                    BrokerInput input = new BrokerInput() {
                        Name = nodeInput["Name"].InnerText,
                        Host = nodeInput["Host"].InnerText,
                    };

                    foreach (XmlNode topic in nodeInput.SelectNodes("Topics/Topic")) {
                        input.Topics.Add(topic.InnerText);
                    }

                    flow.Input = input;
                }
                XmlNode nodeOutput= item.SelectSingleNode("Output");

                if (nodeOutput != null) {

                    OutputType outType = (OutputType)Enum.Parse(typeof(OutputType), nodeOutput.Attributes["Type"].Value);

                    if (outType.ToString() == OutputType.ApiRestOutput.ToString()) {
                        ApiRestOutput output = new ApiRestOutput() {
                            Name = nodeOutput["Name"].InnerText,
                            Url = nodeOutput["Url"].InnerText,
                            Method = nodeOutput["Method"].InnerText
                        };
                        flow.Output = output;
                    } else if (outType.ToString() == OutputType.HtmlFileOutput.ToString()) {
                        FileHtmlOutput output = new FileHtmlOutput() {
                            Name = nodeOutput["Name"].InnerText,
                            Path = nodeOutput["Path"].InnerText,
                            Overwrite = nodeOutput["Overwrite"].InnerText.ToUpper() == "TRUE"
                        };
                        flow.Output = output;
                    }
                }    
                
                flows.Add(flow);
            }
            return flows;
        }

        public bool ExportToXML(string path, Dictionary<int, Flow> flows) {

            XmlDocument doc = new XmlDocument();
            XmlDeclaration dec = doc.CreateXmlDeclaration("1.0", null, null);
            doc.AppendChild(dec);

            XmlElement root = doc.CreateElement("Flows");
            doc.AppendChild(root);

            foreach (var flow in flows.Values) {
                if (flow.Input != null) {

                    XmlElement flowRoot = doc.CreateElement("Flow");
                    root.AppendChild(flowRoot);

                    flowRoot.AppendChild(createInput(doc, flow.Input));

                    if (flow.Output != null) {
                        flowRoot.AppendChild(createOutput(doc, flow.Output));
                    }
                }
            }

            doc.Save(path);

            return true;
        }

        private XmlElement createInput(XmlDocument doc, FlowInput input) {
            XmlElement i = doc.CreateElement("Input");
            i.SetAttribute("Type", input.Type.ToString());

            XmlElement name = doc.CreateElement("Name");
            name.InnerText = input.Name;
            i.AppendChild(name);


            if (input.Type == InputType.ApiRestInput) {
                ApiRestInput apiInput = (ApiRestInput)input;

                XmlElement url = doc.CreateElement("Url");
                url.InnerText = apiInput.Url;
                i.AppendChild(url);

                XmlElement method = doc.CreateElement("Method");
                method.InnerText = apiInput.Method;
                i.AppendChild(method);

            } else if (input.Type == InputType.XmlFileInput) {
                XmlFileInput xmlInput = (XmlFileInput)input;

                XmlElement path = doc.CreateElement("Path");
                path.InnerText = xmlInput.Path;
                i.AppendChild(path);

            } else if (input.Type == InputType.BrokerInput) {
                BrokerInput brokerInput = (BrokerInput)input;

                XmlElement host = doc.CreateElement("Host");
                host.InnerText = brokerInput.Host;
                i.AppendChild(host);

                XmlElement topics = doc.CreateElement("Topics");
                foreach (var topic in brokerInput.Topics) {
                    XmlElement t = doc.CreateElement("Topic");
                    t.InnerText = topic;
                    topics.AppendChild(t);
                }
                i.AppendChild(topics);

            }

            return i;
        }

        private XmlElement createOutput(XmlDocument doc, FlowOutput output) {
            XmlElement o = doc.CreateElement("Output");
            o.SetAttribute("Type", output.Type.ToString());

            XmlElement name = doc.CreateElement("Name");
            name.InnerText = output.Name;
            o.AppendChild(name);

            if (output.Type == OutputType.HtmlFileOutput) {
                FileHtmlOutput fileOutput = (FileHtmlOutput)output;

                XmlElement path = doc.CreateElement("Path");
                path.InnerText = fileOutput.Path;
                o.AppendChild(path);

                XmlElement overwrite = doc.CreateElement("Overwrite");
                overwrite.InnerText = fileOutput.Overwrite ? "true" : "false";
                o.AppendChild(overwrite);

            } else if (output.Type == OutputType.ApiRestOutput) {
                ApiRestOutput apiOutput = (ApiRestOutput)output;

                XmlElement url = doc.CreateElement("Url");
                url.InnerText = apiOutput.Url;
                o.AppendChild(url);

                XmlElement method = doc.CreateElement("Method");
                method.InnerText = apiOutput.Method;
                o.AppendChild(method);
            }


            return o;
        }
    }
}


   