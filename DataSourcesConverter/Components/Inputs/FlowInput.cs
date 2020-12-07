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
        InputType type { get; }

        public abstract string run();
        
    }
    enum InputType
    {
        RestApi,
        XmlFile,
        Broker,
        Excel,
    }
}
