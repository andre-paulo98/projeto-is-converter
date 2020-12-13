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
using DataSourcesConverter.Utils;

namespace DataSourcesConverter {
    public partial class FormHome : Form {

        private Dictionary<int, Flow> flows = new Dictionary<int, Flow>();
        private Dictionary<int, TilesItemView> tilesItemViews = new Dictionary<int, TilesItemView>();
        private int NEXT_ID = 1;

        public FormHome() {
            InitializeComponent();
            Logger.Instance.callback = log;
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

                Object output = flows[id].Output;
                if (selected == OutputType.HtmlFileOutput) {
                    continueOutput = SetParametersFlow<FileHtmlOutput, FormFileHtmlOutput>(ref output);
                } else if (selected == OutputType.ApiRestOutput) {
                    continueOutput = SetParametersFlow<ApiRestOutput, FormApiRestOutput>(ref output);
                }
                flows[id].Output = (FlowOutput)output;
                updateFlowsList(id);


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

                Object input = flows[id].Input;
                if (selected == InputType.ApiRestInput) {
                    continueInput = SetParametersFlow<ApiRestInput, FormApiRestInput>(ref input);
                } else if (selected == InputType.XmlFileInput) {
                    continueInput = SetParametersFlow<XmlFileInput, FormXmlFileInput>(ref input);
                } else if (selected == InputType.BrokerInput) {
                    continueInput = SetParametersFlow<BrokerInput, FormBrokerInput>(ref input);
                }
                flows[id].Input = (FlowInput)input;
                updateFlowsList(id);

            } while (continueInput && isNew);

        }

        /// <summary>
        /// A função é utilizada para definir os parâmetros de cada Input/Output.
        /// A razão pelo qual ser tão complexa, e tão pouco legível, é porque é genérica 
        /// a ponto de permitir definir os campos tanto do Input como do Output. Sendo que existem 
        /// vários tipos de Input (ApiRest, Broker, XmlFile) e vários tipos de Output (ApiRest, FileHtml)
        /// Para tal foi preciso usar métodos genéricos para inicializar ou converter variáveis
        /// </summary>
        /// <typeparam name="CompType">Tipo do Componente</typeparam>
        /// <typeparam name="CompForm">Formulário para editar Componente</typeparam>
        /// <param name="oldObject">O objeto antigo para poder editar</param>
        /// <returns></returns>
        private bool SetParametersFlow<CompType, CompForm>(ref Object oldObject) {
            Object newObject; // XmlFileInput input;
            if (oldObject != null)
                newObject = Convert.ChangeType(oldObject, typeof(CompType)); // input = (XmlFileInput)flows[id].Input;
            else
                newObject = Activator.CreateInstance(typeof(CompType)); // input = new XmlFileInput();

            dynamic form = Activator.CreateInstance(typeof(CompForm), newObject); // FormXmlFileInput form = new FormXmlFileInput(input);

            DialogResult result = form.ShowDialog();
            if (result == DialogResult.OK) {
                oldObject = newObject;
            } else {
                return true;
            }
            return false;

            #region Código exemplo completo sem casts ou instanciar objectos
            /*ApiRestInput input;
            if ((ApiRestInput)flows[id].Input != null)
                input = (ApiRestInput)flows[id].Input;
            else
                input = new ApiRestInput();

            FormApiRestInput form = new FormApiRestInput(input);

            DialogResult result = form.ShowDialog();
            if (result == DialogResult.OK) {
                flows[id].Input = input;
            } else {
                continueInput = true;
            }*/
            #endregion
        }

        private void runCallback(int id) {
            if (flows.ContainsKey(id)) {
                Flow flow = flows[id];
                flow.Input.run((data) => {
                    flow.Output.run(data);
                });
                Logger.Instance.info("MAIN", "Alterar botão");
                if (flow.Input.Type == InputType.BrokerInput) {
                    updateFlowsList(id);
                }

            }
        }

        private void deleteCallback(int id) {
            if (MessageBox.Show("Tem a certeza que prentende apagar este flow?", "Confirmação", MessageBoxButtons.YesNo) == DialogResult.Yes) {
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

            if (needsToAddAnEmptyTile) {
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
            if(saveFileDialog.ShowDialog() == DialogResult.OK) {
                XmlManager xmlManager = new XmlManager();
                xmlManager.ExportToXML(saveFileDialog.FileName, flows);
            }
        }

        private void executarToolStripMenuItem_Click(object sender, EventArgs e) {

        }

        private void adicionarToolStripMenuItem_Click(object sender, EventArgs e) {
            addEmptyTile();
        }



        private void log(string level, string line) {
            level = level.ToUpper();
            string text = "";

            if (level.Equals("STATUS")) {
                text = $"\t {line}";
            } else {
                text = $"[{level}] {line}";
            }

            rtbLog.Invoke(new Action(() => {
                int start = rtbLog.Text.Length;
                rtbLog.AppendText(text);
                rtbLog.Select(start, rtbLog.Text.Length);

                switch (level) {
                    case "ERROR":
                        rtbLog.SelectionColor = Color.Red;
                        break;
                    case "SUCCESS":
                        rtbLog.SelectionColor = Color.Green;
                        break;
                    case "INFO":
                        rtbLog.SelectionColor = Color.Blue;
                        break;
                }
                rtbLog.ScrollToCaret();
            }));
        }

        private void FormHome_FormClosing(object sender, FormClosingEventArgs e) {
            //TODO Fechar conecção do broker 
        }

        private void btClearLog_Click(object sender, EventArgs e) {
            rtbLog.Text = "";
        }
    }
}
