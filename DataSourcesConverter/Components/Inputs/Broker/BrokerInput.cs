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
            Type = InputType.BrokerInput;
        }

        public override void run(ReceiveCallback callback) {
            if (IsConnected) {
                disconnect();
                return;
            }
            this.callback = callback;
            Logger.Instance.info(Type.ToString(), "Ligar a broker");
            connect();

        }

        public void disconnect() {
            if (IsConnected) {
                Logger.Instance.status(Type.ToString(), "A desligar ao broker...");
                if (Topics.Count > 0)
                    mClient.Unsubscribe(Topics.ToArray());
                mClient.Disconnect();
                Logger.Instance.info(Type.ToString(), "Ligar a broker -- Concuido");
            }
        }

        public bool connect() {
            disconnect();
            try {
                Logger.Instance.status(Type.ToString(), "A definir o ip do broker");
                mClient = new MqttClient(Host);
                mClient.Connect(Guid.NewGuid().ToString());
                Logger.Instance.status(Type.ToString(), "Ligado");
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
                Logger.Instance.status(Type.ToString(), "A subscrever canais");
                byte[] qosLevels = new byte[Topics.Count];
                for (int i = 0; i < Topics.Count; i++) {
                    qosLevels[i] = MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE;
                }

                mClient.Subscribe(Topics.ToArray(), qosLevels);
            }
        }

        private void MClient_MqttMsgPublishReceived(object sender, MqttMsgPublishEventArgs e) {
            Logger.Instance.info(Type.ToString(), "Nova mensagem do broker");
            JObject json = new JObject(
                new JProperty("topic", e.Topic),
                new JProperty("message", Encoding.UTF8.GetString(e.Message))
                );
            callback(json.ToString());
        }


    }
}
