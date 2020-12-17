using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using uPLibrary.Networking.M2Mqtt;

namespace dummy_MQTTPublisher {
    public partial class Publisher : Form {

        MqttClient broker;

        public Publisher() {
            InitializeComponent();
        }

        private void btConnect_Click(object sender, EventArgs e) {
            broker = new MqttClient(tbHost.Text);
            broker.Connect(Guid.NewGuid().ToString());

            tbMessage.Enabled = true;
            tbTopic.Enabled = true;
            btPublish.Enabled = true;
        }

        private void btPublish_Click(object sender, EventArgs e) {
            if (broker.IsConnected) {
                broker.Publish(tbTopic.Text, Encoding.UTF8.GetBytes(tbMessage.Text));
            }
        }

        private void Publisher_FormClosing(object sender, FormClosingEventArgs e) {
            if (broker.IsConnected) {
                broker.Unsubscribe(new string[] { tbTopic.Text });
                broker.Disconnect();
            }
        }
    }
}
