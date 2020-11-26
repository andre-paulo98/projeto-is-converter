using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataSourcesConverter.Components.Input
{
    class Input
    {
        public InputType type { get; set; }
        public System.Windows.Forms.Form form { get; set; }
        public List<dynamic> output { get; set; }

        public Input(InputType type, System.Windows.Forms.Form form)
        {
            this.form = form;
            this.type = type;
        }


    }
    enum InputType
    {
        RestApi,
        XmlFile,
        Broker,
        Excel,
    }
}
