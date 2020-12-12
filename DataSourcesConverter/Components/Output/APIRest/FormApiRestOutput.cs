using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataSourcesConverter.Components.Output.APIRest
{
    public partial class FormApiRestOutput : Form
    {
        private ApiRestOutput output;

        public FormApiRestOutput(ApiRestOutput api)
        {
            InitializeComponent();
            output = api;
            tbName.Text = output.Name;
            tb_url.Text = "https://jsonplaceholder.typicode.com/posts"; // output.url;
            cbMethod.SelectedIndex = 1;
        }

        private void bt_cancel_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void bt_save_Click(object sender, EventArgs e) {
            output.Name = tbName.Text;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
