using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataSourcesConverter.Components.Input.APIRest
{
    public partial class FormApiRest : Form
    {
        private static readonly HttpClient client = new HttpClient();

        public FormApiRest()
        {
            InitializeComponent();
        }

        private void bt_request_Click(object sender, EventArgs e)
        {
           Task<string> task = client.GetStringAsync("https://newsapi.org/v1/sources?country=us");

            task.

            task.ContinueWith((x)=>
            {
                this.Invoke((MethodInvoker)delegate
                {
                    rtb_result.Text = x.Result;
                });
                
            });
        }
        private void t(String result)
        {

        }
    }
}
