using System;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace DataSourcesConverter.Components.Inputs.APIRest
{
    public partial class FormApiRest : Form
    {
        private ApiRest output;

        public FormApiRest(ApiRest api)
        {
            InitializeComponent();
            output = api;
            tb_url.Text = output.url;
            cbMethod.SelectedIndex = 0;
        }

        private void bt_request_Click(object sender, EventArgs e)
        {
            if (cbMethod.SelectedIndex == -1) {
                MessageBox.Show("Please select a method to use","Method not set",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                return;
            }

            bt_request.Enabled = false;
            try
            {
                output.url = tb_url.Text;
                output.method = cbMethod.Text;
                rtb_result.Text = output.run();
                                
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
            DialogResult = DialogResult.OK;
            Close();
        }

        private void bt_cancel_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
