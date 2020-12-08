using DataSourcesConverter.Components.Inputs;
using DataSourcesConverter.Components.Output;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSourcesConverter.Components {
    public class Flow {
        public int ID { get; set; }
        public FlowInput Input { get; set; }
        public FlowOutput Output{ get; set; }
    }
}
