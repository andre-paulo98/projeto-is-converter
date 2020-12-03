using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataSourcesConverter.Components.Input
{
    public abstract class Input
    {
        InputType type { get; }

        public abstract Input run();
        
    }
    enum InputType
    {
        RestApi,
        XmlFile,
        Broker,
        Excel,
    }
}
