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

        public List<string> Topics { get; set; }

        public bool IsConnected {
            get {
                return mClient != null && mClient.IsConnected;
            }
        }

        public BrokerInput() {
            Topics = new List<string>();
            Type = InputType.Broker;
        }

        public override void run(ReceiveCallback callback) {
            if (IsConnected) {
                disconnect();
                return;
            }
            this.callback = callback;
            connect();

        }

        public void disconnect() {
            if (IsConnected) {
                if (Topics.Count > 0)
                    mClient.Unsubscribe(Topics.ToArray());
                mClient.Disconnect();
            }
        }

        public bool connect() {
            disconnect();
            try {
                mClient = new MqttClient(Host);
                mClient.Connect(Guid.NewGuid().ToString());

                if (Topics.Count > 0)
                    subscribe();

            } catch (Exception e) {
                throw new Exception("Broker Input: " + e.InnerException.Message);
            }
            mClient.MqttMsgPublishReceived += MClient_MqttMsgPublishReceived;

            return mClient.IsConnected;
        }


        private void subscribe() {
            if (IsConnected) {
                byte[] qosLevels = new byte[Topics.Count];
                for (int i = 0; i < Topics.Count; i++) {
                    qosLevels[i] = MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE;
                }

                mClient.Subscribe(Topics.ToArray(), qosLevels);
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
