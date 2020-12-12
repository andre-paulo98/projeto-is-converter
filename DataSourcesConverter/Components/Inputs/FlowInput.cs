using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataSourcesConverter.Components.Inputs
{
    public abstract class FlowInput
    {
        public InputType Type { get; }
        public string Name { get; set; }
        public abstract void run(ReceiveCallback callback);
    }

    public delegate void ReceiveCallback(string data);


    public enum InputType
    {
        RestApi,
        XmlFile,
        Broker,
        Excel,
    }
}
