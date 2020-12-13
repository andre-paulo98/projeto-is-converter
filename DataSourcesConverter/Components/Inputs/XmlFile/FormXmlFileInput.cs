using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace DataSourcesConverter.Components.Inputs.XmlFile {
    public partial class FormXmlFileInput : Form {

        XmlFileInput xmlFile;

        public FormXmlFileInput(XmlFileInput file) {
            InitializeComponent();
            xmlFile = file;
            tbName.Text = xmlFile.Name;
            tbFilePath.Text = xmlFile.Path;
        }

        private void btChooseFile_Click(object sender, EventArgs e) {
            if (openFileDialog.ShowDialog(this) == DialogResult.OK) {
                xmlFile.Path = openFileDialog.FileName;
                tbFilePath.Text = xmlFile.Path;
                XmlNode doc = null;
                try {
                    doc = xmlFile.readFile();
                }catch(Exception ex) {
                    MessageBox.Show(ex.Message,"Erro a ler o ficheiro XML", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                using (var sw = new System.IO.StringWriter())
                using (var xw = new System.Xml.XmlTextWriter(sw)) {
                    xw.Formatting = System.Xml.Formatting.Indented;
                    doc.WriteContentTo(xw);
                    rtbResult.Text = sw.ToString();
                }
                btSave.Enabled = true;
            }
        }

        private void btSave_Click(object sender, EventArgs e) {
            xmlFile.Path = tbFilePath.Text;
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
