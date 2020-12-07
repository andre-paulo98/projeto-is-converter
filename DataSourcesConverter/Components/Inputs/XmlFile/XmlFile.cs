﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace DataSourcesConverter.Components.Inputs.XmlFile {
    public class XmlFile : FlowInput {
        public string filePath { get; set; }
        XmlDocument dom;

        public XmlFile() {
            dom = new XmlDocument();
        }

        public override string run() {
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
