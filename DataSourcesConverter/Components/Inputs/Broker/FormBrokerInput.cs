using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataSourcesConverter.Components.Inputs.Broker
{
    public partial class FormBrokerInput : Form
    {

        BrokerInput brokerInput;
        List<string> topics;

        public FormBrokerInput(BrokerInput brokerInput)
        {
            InitializeComponent();
            this.brokerInput = brokerInput;
            topics = brokerInput.topics;
            lboxTopics.DataSource = topics;
        }

        private void btConnect_Click(object sender, EventArgs e)
        {
            brokerInput.host = tbHost.Text;
            if (brokerInput.connect())
            {
                gbListTopics.Enabled = true;
            }
        }

        private void tbAdd_Click(object sender, EventArgs e)
        {
            topics.Add(tbTopic.Text);
        }

        private void btRemove_Click(object sender, EventArgs e)
        {
            topics.Remove(lboxTopics.SelectedItem.ToString());
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            brokerInput.addTopics(topics);
            Close();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lboxTopics_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lboxTopics.SelectedIndex != -1)
            {
                btRemove.Enabled = true;
            }
        }
    }
}
