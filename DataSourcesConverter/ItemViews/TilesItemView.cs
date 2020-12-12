using DataSourcesConverter.Components;
using DataSourcesConverter.Components.Inputs;
using DataSourcesConverter.Components.Inputs.Broker;
using DataSourcesConverter.Components.Output;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataSourcesConverter.teste {
    public partial class TilesItemView : UserControl {


        public Flow Flow { get; private set; }

        public delegate void RunCallback(int id);
        public delegate void DeleteCallback(int id);
        public delegate void SetInputCallback(int id);
        public delegate void SetOutputCallback(int id);

        private RunCallback runCallback;
        private DeleteCallback deleteCallback;
        private SetInputCallback setInputCallback;
        private SetOutputCallback setOutputCallback;

        public TilesItemView() {
        }

        public TilesItemView(Flow flow, RunCallback runCallback, SetInputCallback setInputCallback, SetOutputCallback setOutputCallback, DeleteCallback deleteCallback) {

            if (flow == null) {
                flow = new Flow {
                    ID = -1
                };
            }

            this.Flow = flow;
            this.runCallback = runCallback;
            this.setInputCallback = setInputCallback;
            this.setOutputCallback = setOutputCallback;
            this.deleteCallback = deleteCallback;

            InitializeComponent();

            btSetInput.Dock = DockStyle.Fill;
            btSetOutput.Dock = DockStyle.Fill;

            groupBoxInput.Click += SetInput_Click;
            groupBoxOutput.Click += SetOutput_Click;
            updateInterface();

            this.Dock = DockStyle.Fill;
        }

        private void updateInterface() {
            if (Flow.Input != null) {
                lblTypeInput.Text = Enum.GetName(typeof(InputType), Flow.Input.Type);
                lblNameInput.Text = Flow.Input.Name;
                btSetInput.Visible = false;
                panelOutput.Enabled = true;
            } /*else {
                panelOutput.Enabled = false;
            }*/

            if (Flow.Output != null) {
                lblTypeOutput.Text = Enum.GetName(typeof(OutputType), Flow.Output.Type);
                lblNameOutput.Text = Flow.Output.Name;
                btSetOutput.Visible = false;
            }

            if (Flow.Input == null || Flow.Output == null) {
                btRun.Visible = false;
            } else {
                btRun.Visible = true;
            }

            if(Flow.Input == null) {
                btDelete.Visible = false;
            } else {
                btDelete.Visible = true;
            }

            if(Flow.Input != null && Flow.Input.Type == InputType.Broker && ((BrokerInput)Flow.Input).IsConnected) {
                btRun.BackgroundImage = Properties.Resources.pause_button;
            } else {
                btRun.BackgroundImage = Properties.Resources.run_button;
            }
        }

        public void updateFlow(/*Flow flow*/) {
            //this.Flow = flow;
            updateInterface();
        }

        private void SetInput_Click(object sender, EventArgs e) {
            setInputCallback(Flow.ID);
        }

        private void SetOutput_Click(object sender, EventArgs e) {
            setOutputCallback(Flow.ID);
        }

        private void btRun_Click(object sender, EventArgs e) {
            runCallback(Flow.ID);
        }

        private void btDelete_Click(object sender, EventArgs e) {
            deleteCallback(Flow.ID);
        }
    }
}
