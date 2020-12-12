using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Exceptions;
using uPLibrary.Networking.M2Mqtt.Messages;

namespace DataSourcesConverter.Components.Inputs.Broker {
    public class BrokerInput : FlowInput {

        MqttClient mClient = null;
        ReceiveCallback callback;

        public string Host { get; set; }

        public List<string> Topics { get; private set; }

        public BrokerInput() {
            Topics = new List<string>();
            Type = InputType.Broker;
        }

        public override void run(ReceiveCallback callback) {
            this.callback = callback;
        }

        public bool connect() {
            if (mClient != null && mClient.IsConnected) {
                mClient.Unsubscribe(Topics.ToArray());
                mClient.Disconnect();
            }
            try {
                mClient = new MqttClient(Host);
                mClient.Connect(Guid.NewGuid().ToString());
            } catch (Exception e) {
                throw new Exception("Broker Input: " + e.InnerException.Message);
            }
            mClient.MqttMsgPublishReceived += MClient_MqttMsgPublishReceived;

            return mClient.IsConnected;
        }

        public void addTopics(List<string> newTopics) {
            if (mClient != null && mClient.IsConnected) {
                if(Topics.Count > 0)
                    mClient.Unsubscribe(Topics.ToArray());

                byte[] qosLevels = new byte[newTopics.Count];
                for (int i = 0; i < newTopics.Count; i++) {
                    qosLevels[i] = MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE;
                }

                mClient.Subscribe(newTopics.ToArray(), qosLevels);

                Topics = newTopics;
            }
        }

        private void MClient_MqttMsgPublishReceived(object sender, MqttMsgPublishEventArgs e) {
            JObject json = new JObject(
                new JProperty("topic", e.Topic),
                new JProperty("message", Encoding.UTF8.GetString(e.Message))
                );
            callback(json.ToString());
        }


    }
}
