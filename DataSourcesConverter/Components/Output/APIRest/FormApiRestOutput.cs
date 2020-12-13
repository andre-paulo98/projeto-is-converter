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
            tb_url.Text = output.Url;
            cbMethod.SelectedIndex = 1;
        }

        private void btSave_Click(object sender, EventArgs e) {
            output.Name = tbName.Text;
            output.Url = tb_url.Text;
            output.Method = cbMethod.Text;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btCancel_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
