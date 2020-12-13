using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataSourcesConverter.Components.Inputs.Broker {
    public partial class FormBrokerInput : Form {

        BrokerInput brokerInput;
        BindingList<string> topics;

        public FormBrokerInput(BrokerInput brokerInput) {
            InitializeComponent();
            this.brokerInput = brokerInput;
            topics = new BindingList<string>(brokerInput.Topics);
            lboxTopics.DataSource = topics;
            if (topics.Count > 0) {
                gbListTopics.Enabled = true;
                btSave.Enabled = true;
            }
            tbName.Text = brokerInput.Name;
            tbHost.Text = brokerInput.Host;
        }

        private void btConnect_Click(object sender, EventArgs e) {
            brokerInput.Host = tbHost.Text;

            if (tbHost.Text.Equals(string.Empty)) {
                MessageBox.Show("Por favor indique um endereço", "Endereço invalido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try {
                btConnect.Enabled = false;
                brokerInput.connect();
                gbListTopics.Enabled = true;
            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Erro na ligação ao broker", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            btConnect.Enabled = true;
        }

        private void tbAdd_Click(object sender, EventArgs e) {
            if(tbTopic.Text.Length <= 0) {
                MessageBox.Show("Por favor introduza o nome do tópico a subscrever!","Nome do tópico não definido",MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (topics.Contains(tbTopic.Text)) {
                MessageBox.Show("O tópico que introduziu já se encontra na lista!", "Tópico já existente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            topics.Add(tbTopic.Text);
            tbTopic.Text = "";
            btSave.Enabled = true;
            btRemove.Enabled = true;
        }

        private void btRemove_Click(object sender, EventArgs e) {
            topics.RemoveAt(lboxTopics.SelectedIndex);
            if (topics.Count <= 0) {
                btRemove.Enabled = false;
                btSave.Enabled = false;
            }
        }

        private void btSave_Click(object sender, EventArgs e) {
            brokerInput.Name = tbName.Text;
            brokerInput.Host = tbHost.Text;
            brokerInput.Topics = topics.ToList();
            DialogResult = DialogResult.OK;
            brokerInput.disconnect();
            Close();
        }

        private void btCancel_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void lboxTopics_SelectedIndexChanged(object sender, EventArgs e) {
            if (lboxTopics.SelectedIndex != -1) {
                btRemove.Enabled = true;
            }
        }
    }
}
