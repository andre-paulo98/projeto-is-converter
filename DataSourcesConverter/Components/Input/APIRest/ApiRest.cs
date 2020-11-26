using DataSourcesConverter.Components.Input.APIRest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSourcesConverter.Components.Input
{
    class ApiRest: Input
    {
        public string url { get; set; }
        public string dataField { get; set; }

        public ApiRest(): base(InputType.RestApi, new FormApiRest())
        {
            
        }

    }
}
