﻿using DataSourcesConverter.Components.Inputs.APIRest;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataSourcesConverter {
    public partial class FormHome : Form {
        public FormHome() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormApiRest form = new FormApiRest();
            form.ShowDialog();
            var a = form.output;
        }

        private void cb_inputType_SelectedIndexChanged(object sender, EventArgs e)
        {

            

        }
    }
}
