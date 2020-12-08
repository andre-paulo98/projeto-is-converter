using DataSourcesConverter.Components.Inputs;
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

namespace DataSourcesConverter.Components {
    public partial class FormSelectType : Form {

        public InputType? InputTypeSelected { get; private set; } = null;
        public OutputType? OutputTypeSelected { get; private set; } = null;

        private bool isInput;

        public FormSelectType(bool isInput) {

            InitializeComponent();

            this.isInput = isInput;

            if(isInput) {
                cbTypes.DataSource = Enum.GetNames(typeof(InputType)).ToList();
            } else {
                cbTypes.DataSource = Enum.GetNames(typeof(OutputType)).ToList();
            }
            
        }

        private void btSelect_Click(object sender, EventArgs e) {
            if (isInput) {
                InputTypeSelected = (InputType)Enum.Parse(typeof(InputType), cbTypes.SelectedItem.ToString());
            } else {
                OutputTypeSelected = (OutputType)Enum.Parse(typeof(OutputType), cbTypes.SelectedItem.ToString());
            }

            Close();
        }
    }
}
