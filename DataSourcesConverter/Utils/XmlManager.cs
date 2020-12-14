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
using System.Xml.Schema;

namespace DataSourcesConverter.Utils {
    class XmlManager {

        private bool isValid;

        public bool ValidateXML(string path) {
            isValid = true;
            try {
                XmlDocument doc = new XmlDocument();
                doc.Load(path);
                ValidationEventHandler eventHandler = new ValidationEventHandler(ValidateMethod);
                doc.Schemas.Add(null, "schema.xsd");
                doc.Validate(eventHandler);
            } catch (XmlException e) {
                isValid = false;
                Logger.Instance.error("XML-VALIDATOR", e.ToString());
            }

            return isValid;
        }

        private void ValidateMethod(object sender, ValidationEventArgs args) {
            isValid = false;
            switch (args.Severity) {
                case XmlSeverityType.Error:
                    Logger.Instance.error("XML-VALIDATOR", args.Message);
                    break;
                case XmlSeverityType.Warning:
                    Logger.Instance.warning("XML-VALIDATOR", args.Message);
                    break;
                default:
                    break;
            }
        }

        public List<Flow> ImportXML(string path) {

            XmlDocument doc = new XmlDocument();
            doc.Load(path);

            List<Flow> flows = new List<Flow>();

            XmlNodeList nodes = doc.SelectNodes($"/Flows/Flow");

            foreach (XmlNode item in nodes) {

                Flow flow = new Flow();

                XmlNode nodeInput = item.FirstChild;
                InputType inputType = (InputType)Enum.Parse(typeof(InputType), nodeInput.Name);

                if (inputType.ToString() == InputType.ApiRestInput.ToString()) {
                    ApiRestInput input = new ApiRestInput() {
                        Name = nodeInput.Attributes["Name"].Value,
                        Url = nodeInput["Url"].InnerText,
                        Method = nodeInput["Method"].InnerText
                    };
                    flow.Input = input;
                } else if (inputType.ToString() == InputType.XmlFileInput.ToString()) {
                    XmlFileInput input = new XmlFileInput() {
                        Name = nodeInput.Attributes["Name"].Value,
                        Path = nodeInput["Path"].InnerText
                    };
                    flow.Input = input;
                } else if (inputType.ToString() == InputType.BrokerInput.ToString()) {
                    BrokerInput input = new BrokerInput() {
                        Name = nodeInput.Attributes["Name"].Value,
                        Host = nodeInput["Host"].InnerText,
                    };

                    foreach (XmlNode topic in nodeInput.SelectNodes("Topics/Topic")) {
                        input.Topics.Add(topic.InnerText);
                    }

                    flow.Input = input;
                }

                if(item.ChildNodes.Count == 2) {
                    XmlNode nodeOutput = item.ChildNodes[1];

                    OutputType outType = (OutputType)Enum.Parse(typeof(OutputType), nodeOutput.Name);

                    if (outType.ToString() == OutputType.ApiRestOutput.ToString()) {
                        ApiRestOutput output = new ApiRestOutput() {
                            Name = nodeOutput.Attributes["Name"].Value,
                            Url = nodeOutput["Url"].InnerText,
                            Method = nodeOutput["Method"].InnerText
                        };
                        flow.Output = output;
                    } else if (outType.ToString() == OutputType.HtmlFileOutput.ToString()) {
                        FileHtmlOutput output = new FileHtmlOutput() {
                            Name = nodeOutput.Attributes["Name"].Value,
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
            if (input.Type == InputType.ApiRestInput) {
                ApiRestInput apiInput = (ApiRestInput)input;

                XmlElement i = doc.CreateElement(InputType.ApiRestInput.ToString());
                i.SetAttribute("Name", apiInput.Name);

                XmlElement url = doc.CreateElement("Url");
                url.InnerText = apiInput.Url;
                i.AppendChild(url);

                XmlElement method = doc.CreateElement("Method");
                method.InnerText = apiInput.Method;
                i.AppendChild(method);

                return i;

            } else if (input.Type == InputType.XmlFileInput) {
                XmlFileInput xmlInput = (XmlFileInput)input;

                XmlElement i = doc.CreateElement(InputType.XmlFileInput.ToString());
                i.SetAttribute("Name", xmlInput.Name);

                XmlElement path = doc.CreateElement("Path");
                path.InnerText = xmlInput.Path;
                i.AppendChild(path);

                return i;

            } else if (input.Type == InputType.BrokerInput) {
                BrokerInput brokerInput = (BrokerInput)input;

                XmlElement i = doc.CreateElement(InputType.BrokerInput.ToString());
                i.SetAttribute("Name", brokerInput.Name);

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

                return i;

            } else {

                XmlElement i = doc.CreateElement("Input");
                i.SetAttribute("Name", input.Name);

                return i;
            }

        }

        private XmlElement createOutput(XmlDocument doc, FlowOutput output) {
            if (output.Type == OutputType.HtmlFileOutput) {
                FileHtmlOutput fileOutput = (FileHtmlOutput)output;

                XmlElement o = doc.CreateElement(OutputType.HtmlFileOutput.ToString());
                o.SetAttribute("Name", fileOutput.Name);

                XmlElement path = doc.CreateElement("Path");
                path.InnerText = fileOutput.Path;
                o.AppendChild(path);

                XmlElement overwrite = doc.CreateElement("Overwrite");
                overwrite.InnerText = fileOutput.Overwrite ? "true" : "false";
                o.AppendChild(overwrite);

                return o;

            } else if (output.Type == OutputType.ApiRestOutput) {
                ApiRestOutput apiOutput = (ApiRestOutput)output;

                XmlElement o = doc.CreateElement(OutputType.ApiRestOutput.ToString());
                o.SetAttribute("Name", apiOutput.Name);

                XmlElement url = doc.CreateElement("Url");
                url.InnerText = apiOutput.Url;
                o.AppendChild(url);

                XmlElement method = doc.CreateElement("Method");
                method.InnerText = apiOutput.Method;
                o.AppendChild(method);

                return o;

            } else {

                XmlElement o = doc.CreateElement("Output");
                o.SetAttribute("Name", output.Name);

                return o;

            }
        }
    }
}


   