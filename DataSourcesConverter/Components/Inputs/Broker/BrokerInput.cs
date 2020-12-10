using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;

namespace DataSourcesConverter.Components.Inputs.Broker
{
    public class BrokerInput :FlowInput
    {
        public delegate void ReciveCallback(string data);

        MqttClient mClient = null;
        ReciveCallback reciveCallback;

        public string host { get; set; }

        public List<string> topics { get; private set; }

        public BrokerInput(ReciveCallback reciveCallback)
        {
            this.reciveCallback = reciveCallback;
        }

        public override string run()
        {
            connect();
            return "";
        }

        public bool connect()
        {
            if(mClient != null || mClient.IsConnected)
            {
                mClient.Unsubscribe(topics.ToArray());
                mClient.Disconnect();
            }

            mClient = new MqttClient(host);
            mClient.Connect(Guid.NewGuid().ToString());

            mClient.MqttMsgPublishReceived += MClient_MqttMsgPublishReceived;

            return mClient.IsConnected;
        }

        public void addTopics(List<string> newTopics)
        {
            if(mClient != null && mClient.IsConnected)
            {
                mClient.Unsubscribe(topics.ToArray());

                byte[] qosLevels = {MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE};
                mClient.Subscribe(newTopics.ToArray(), qosLevels);

                topics = newTopics;
            }
        }

        private void MClient_MqttMsgPublishReceived(object sender, MqttMsgPublishEventArgs e)
        {
            JObject json = new JObject(
                new JProperty("topic", e.Topic),
                new JProperty("message", Encoding.UTF8.GetString(e.Message))
                );
            reciveCallback(json.ToString());
        }


    }
}
