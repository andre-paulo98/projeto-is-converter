using DataSourcesConverter.Utils;
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
                disconnect(true);
                return;
            }
            this.callback = callback;
            Logger.Instance.info(Type.ToString(), "Ligar a broker");
            connect(true);

        }

        public void disconnect(bool log = false) {
            if (IsConnected) {
                if (log)
                    Logger.Instance.status(Type.ToString(), "A desligar ao broker...");
                if (Topics.Count > 0)
                    mClient.Unsubscribe(Topics.ToArray());
                mClient.Disconnect();
                if (log)
                    Logger.Instance.success(Type.ToString(), "Ligar a broker -- Concuido");
            }
        }

        public bool connect(bool log = false) {
            disconnect(log);
            try {
                if (log)
                    Logger.Instance.status(Type.ToString(), "A definir o ip do broker...");
                mClient = new MqttClient(Host);
                if (log)
                    Logger.Instance.status(Type.ToString(), "A conectar ao broker...");
                mClient.Connect(Guid.NewGuid().ToString());
                if (Topics.Count > 0)
                    subscribe();

                mClient.MqttMsgPublishReceived += MClient_MqttMsgPublishReceived;

            } catch (Exception e) {
                if (log) {
                    Logger.Instance.error(Type.ToString(), "Erro a ligar ao broker: ");
                    Logger.Instance.status(Type.ToString(), e.Message);
                } else {
                    throw e;
                }
                return false;
            }


            return mClient.IsConnected;
        }


        private void subscribe() {
            if (IsConnected) {
                Logger.Instance.status(Type.ToString(), "A subscrever canais...");
                byte[] qosLevels = new byte[Topics.Count];
                for (int i = 0; i < Topics.Count; i++) {
                    qosLevels[i] = MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE;
                }

                mClient.Subscribe(Topics.ToArray(), qosLevels);
            }
        }

        private void MClient_MqttMsgPublishReceived(object sender, MqttMsgPublishEventArgs e) {
            Logger.Instance.info(Type.ToString(), "Nova mensagem do broker!!!");
            JObject json = new JObject(
                new JProperty("topic", e.Topic),
                new JProperty("message", Encoding.UTF8.GetString(e.Message))
                );
            callback(json.ToString());
        }


    }
}
