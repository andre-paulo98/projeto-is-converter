using System;
using System.Dynamic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web.Helpers;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace DataSourcesConverter.Components.Input.APIRest
{
    public partial class FormApiRest : Form
    {
        private HttpClient client = new HttpClient();
        public ApiRest output;

        public FormApiRest()
        {
            InitializeComponent();
            output = new ApiRest();
        }

        private async Task<string> GetProductAsync()
        {
            string body = null;
            HttpResponseMessage response = await client.GetAsync(client.BaseAddress);
            if (response.IsSuccessStatusCode)
            {
                body = await response.Content.ReadAsStringAsync();
            }
            return body;
        }

        private async void bt_request_Click(object sender, EventArgs e)
        {
            bt_request.Enabled = false;
            client.BaseAddress = new Uri(tb_url.Text);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            //Get request body as json String
            string body = await GetProductAsync();
            rtb_result.Text = body;
            
            bt_request.Enabled = true;
        }

        private void FormApiRest_Load(object sender, EventArgs e)
        {

        }

        private void bt_save_Click(object sender, EventArgs e)
        {
            output.url = tb_url.Text;
            Close();
        }

    }
}
