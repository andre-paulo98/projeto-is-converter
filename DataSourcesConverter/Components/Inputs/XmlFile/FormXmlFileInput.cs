﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataSourcesConverter.Components.Inputs.XmlFile {
    public partial class FormXmlFileInput : Form {

        XmlFileInput xmlFile;
        
        public FormXmlFileInput(XmlFileInput file) {
            InitializeComponent();
            xmlFile = file;
            tbName.Text = xmlFile.Name;
            tbFilePath.Text = xmlFile.path;
        }

        private void btChooseFile_Click(object sender, EventArgs e) {
            if (openFileDialog.ShowDialog(this) == DialogResult.OK) {
                xmlFile.path = openFileDialog.FileName;
                tbFilePath.Text = xmlFile.path;
                rtbResult.Text = xmlFile.getResponse();
                btSave.Enabled = true;
            }
        }

        private void btSave_Click(object sender, EventArgs e) {
            xmlFile.path = tbFilePath.Text;
            xmlFile.Name = tbName.Text;

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btCancel_Click(object sender, EventArgs e) {

            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
