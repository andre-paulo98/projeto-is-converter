using DataSourcesConverter.Components;
using DataSourcesConverter.Components.Inputs;
using DataSourcesConverter.Components.Inputs.APIRest;
using DataSourcesConverter.Components.Output.FileHtmlOutput;
using DataSourcesConverter.teste;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataSourcesConverter {
    public partial class FormHome : Form {

        private Dictionary<int, Flow> flows = new Dictionary<int, Flow>();
        private Dictionary<int, TilesItemView> tilesItemViews = new Dictionary<int, TilesItemView>();
        private int NEXT_ID = 1;

        public FormHome() {
            InitializeComponent();
        }

        

        private void FormHome_Load(object sender, EventArgs e) {

            Flow flow = new Flow() { ID = NEXT_ID++, Input = null, Output = null };
            flows.Add(flow.ID, flow);

            TilesItemView tile = new TilesItemView(flow, runCallback, setInputCallback, setOutputCallback);
            tilesItemViews.Add(flow.ID, tile);


            flowsPanel.Controls.Add(tile);
            flowLayoutPanel1_SizeChanged(null, null);


        }

        private void setOutputCallback(int id) {
            throw new NotImplementedException();
        }

        private void setInputCallback(int id) {

            InputType selected;
            if(flows[id].Input == null) {
                FormSelectType select = new FormSelectType(true);
                select.ShowDialog(); // TODO check if result was ok
                selected = select.InputTypeSelected.Value;
            } else {
                selected = flows[id].Input.Type;
            }

            if (selected == InputType.RestApi) {
                ApiRest input;
                if ((ApiRest)flows[id].Input != null)
                    input = (ApiRest)flows[id].Input;
                else
                    input = new ApiRest();

                FormApiRestInput form = new FormApiRestInput(input);
                form.ShowDialog();

                flows[id].Input = input;
                updateFlowsList(id);

            } else if (selected == InputType.XmlFile) {
                //
            }
        }

        private void runCallback(int id) {
            throw new NotImplementedException();
        }

        private void updateFlowsList(int id) {
            TilesItemView tile = tilesItemViews[id];
            if(tile != null) {
                tile.updateFlow();
            }

        }

        private void flowLayoutPanel1_SizeChanged(object sender, EventArgs e) {
            panelFirstItemFlowLayout.Size = new Size(flowsPanel.Size.Width - (flowsPanel.VerticalScroll.Visible ? SystemInformation.VerticalScrollBarWidth : 0) - 5, 1);
        }
    }
}
