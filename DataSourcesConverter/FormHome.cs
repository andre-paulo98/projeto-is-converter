using DataSourcesConverter.Components;
using DataSourcesConverter.Components.Inputs;
using DataSourcesConverter.Components.Inputs.APIRest;
using DataSourcesConverter.Components.Inputs.XmlFile;
using DataSourcesConverter.Components.Inputs.Broker;
using DataSourcesConverter.Components.Output;
using DataSourcesConverter.Components.Output.FileHtml;
using DataSourcesConverter.Components.Output.APIRest;
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
            addEmptyTile();
        }

        private void setOutputCallback(int id) {
            bool continueOutput;
            bool isNew = false;

            do {
                continueOutput = false;

                OutputType selected;

                if (flows[id].Output == null) {
                    FormSelectType select = new FormSelectType(false);
                    DialogResult result = select.ShowDialog();
                    if (result != DialogResult.OK) {
                        return;
                    }
                    selected = select.OutputTypeSelected.Value;
                    isNew = true;
                } else {
                    selected = flows[id].Output.Type;
                }

                if (selected == OutputType.HtmlFile) {
                    FileHtmlOutput output;
                    if ((FileHtmlOutput)flows[id].Output != null)
                        output = (FileHtmlOutput)flows[id].Output;
                    else
                        output = new FileHtmlOutput();

                    FormFileHtmlOutput form = new FormFileHtmlOutput(output);

                    DialogResult result = form.ShowDialog();
                    if (result == DialogResult.OK) {
                        flows[id].Output = output;
                        updateFlowsList(id);
                    } else {
                        continueOutput = true;
                    }


                } else if (selected == OutputType.ApiRest) {
                    ApiRestOutput output;
                    if ((ApiRestOutput)flows[id].Output != null)
                        output = (ApiRestOutput)flows[id].Output;
                    else
                        output = new ApiRestOutput();

                    FormApiRestOutput form = new FormApiRestOutput(output);

                    DialogResult result = form.ShowDialog();
                    if (result == DialogResult.OK) {
                        flows[id].Output = output;
                        updateFlowsList(id);
                    } else {
                        continueOutput = true;
                    }


                }

                /*else if (selected == OutputType.OUTRACENA) {
                    //
                }*/


            } while (continueOutput && isNew);


        }

        private void setInputCallback(int id) {

            bool continueInput;
            bool isNew = false;

            do {

                continueInput = false;

                InputType selected;
                if (flows[id].Input == null) {
                    FormSelectType select = new FormSelectType(true);
                    DialogResult result = select.ShowDialog();
                    if (result != DialogResult.OK) {
                        return;
                    }
                    selected = select.InputTypeSelected.Value;
                    isNew = true;
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

                    DialogResult result = form.ShowDialog();
                    if (result == DialogResult.OK) {
                        flows[id].Input = input;
                        updateFlowsList(id);
                    } else {
                        continueInput = true;
                    }


                } else if (selected == InputType.XmlFile) {
                    XmlFileInput input;
                    if ((XmlFileInput)flows[id].Input != null)
                        input = (XmlFileInput)flows[id].Input;
                    else
                        input = new XmlFileInput();

                    FormXmlFileInput form = new FormXmlFileInput(input);

                    DialogResult result = form.ShowDialog();
                    if (result == DialogResult.OK) {
                        flows[id].Input = input;
                        updateFlowsList(id);
                    } else {
                        continueInput = true;
                    }
                } else if (selected == InputType.Broker) {
                    BrokerInput input;
                    if ((BrokerInput)flows[id].Input != null)
                        input = (BrokerInput)flows[id].Input;
                    else
                        input = new BrokerInput();

                    FormBrokerInput form = new FormBrokerInput(input);

                    DialogResult result = form.ShowDialog();
                    if (result == DialogResult.OK) {
                        flows[id].Input = input;
                        updateFlowsList(id);
                    } else {
                        continueInput = true;
                    }
                }

            } while (continueInput && isNew);
            
        }

        private void runCallback(int id) {
            if(flows.ContainsKey(id)) {
                Flow flow = flows[id];
                flow.Input.run((data) => { flow.Output.run(data); });
                if (flow.Input.Type == InputType.Broker) {
                    updateFlowsList(id);
                }
            }
        }

        private void deleteCallback(int id) {
            if(MessageBox.Show("Tem a certeza que prentende apagar este flow?", "Confirmação", MessageBoxButtons.YesNo) == DialogResult.Yes) {
                updateFlowsList(id, true);
                flows.Remove(id);
                tilesItemViews.Remove(id);
            }
            
        }

        private void updateFlowsList(int id, bool setToDelete = false) {
            TilesItemView tile = tilesItemViews[id];
            if (setToDelete) {
                flowsPanel.Controls.Remove(tile);

            } else if (tile != null) {
                tile.updateFlow();
            }

            

            bool needsToAddAnEmptyTile = true; // se todos os tiles já tiverem com input preenchidos
            foreach (var item in tilesItemViews.Values) {
                if (item.Flow.Input == null)
                    needsToAddAnEmptyTile = false;
            }

            if(needsToAddAnEmptyTile) {
                addEmptyTile();
            }

        }

        private void addEmptyTile() {
            Flow flow = new Flow() { ID = NEXT_ID++, Input = null, Output = null };
            flows.Add(flow.ID, flow);

            TilesItemView tile = new TilesItemView(flow, runCallback, setInputCallback, setOutputCallback, deleteCallback);
            tilesItemViews.Add(flow.ID, tile);

            flowsPanel.Controls.Add(tile);

            flowLayoutPanel1_SizeChanged(null, null);
        }

        private void flowLayoutPanel1_SizeChanged(object sender, EventArgs e) {
            panelFirstItemFlowLayout.Size = new Size(flowsPanel.Size.Width - (flowsPanel.VerticalScroll.Visible ? SystemInformation.VerticalScrollBarWidth : 0) - 5, 1);
        }

        private void importarXMLToolStripMenuItem_Click(object sender, EventArgs e) {

        }

        private void exportarXMLToolStripMenuItem_Click(object sender, EventArgs e) {

        }

        private void executarToolStripMenuItem_Click(object sender, EventArgs e) {

        }

        private void adicionarToolStripMenuItem_Click(object sender, EventArgs e) {
            addEmptyTile();
        }
    }
}
