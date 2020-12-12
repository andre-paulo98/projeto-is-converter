using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSourcesConverter.Components.Output {
    public abstract class FlowOutput {
        public OutputType Type { get; protected set; }
        public string Name { get; set; }

        public abstract bool run(string data);

    }

    public enum OutputType {
        HtmlFileOutput,
        ApiRestOutput
    }
}
