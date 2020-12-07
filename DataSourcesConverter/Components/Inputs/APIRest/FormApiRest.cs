using System;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace DataSourcesConverter.Components.Inputs.APIRest
{
    public partial class FormApiRest : Form
    {
        public ApiRest output;

        public FormApiRest()
        {
            InitializeComponent();
            output = new ApiRest();
        }

        private void bt_request_Click(object sender, EventArgs e)
        {

            bt_request.Enabled = false;
            
            try
            {
                JToken json = ApiRest.makeRequest(tb_url.Text);
                rtb_result.Text = json.ToString();

                output.url = tb_url.Text;
                bt_save.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Api Rest error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                bt_request.Enabled = true;
            }
                
        }

        private void bt_save_Click(object sender, EventArgs e)
        {
            output.url = tb_url.Text;
            Close();
        }

        private void bt_cancel_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
