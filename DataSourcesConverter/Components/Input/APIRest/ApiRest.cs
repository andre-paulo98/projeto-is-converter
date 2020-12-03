using DataSourcesConverter.Components.Input.APIRest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataSourcesConverter.Components.Input
{
    public class ApiRest: Input
    {

        public string url { get; set; }

        public ApiRest()
        {
            
        }

        public override Input run()
        {
            //var converter = new ExpandoObjectConverter();
            //dynamic output = JsonConvert.DeserializeObject<ExpandoObject>(body, converter);
            return null;
        }

        

        private Task<string> makeRequest()
        {
            string body = null;
            //TODO: NÃO QUEREMOS ASYNC
            HttpResponseMessage response = client.GetAsync(client.BaseAddress);
            if (response.IsSuccessStatusCode)
            {
                body = await response.Content.ReadAsStringAsync();
            }
            return body;
        }
    }
}
