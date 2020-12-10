using System;
using System.IO;
using System.Windows.Forms;

namespace DataSourcesConverter.Components.Output.FileHtmlOutput {
    public partial class FormFileHtmlOutput : Form {

        private FileHtmlOutput fileHtml;
        public bool newFile;

        public FormFileHtmlOutput(FileHtmlOutput fileHtmlOutput) {
            InitializeComponent();
            fileHtml = fileHtmlOutput;
            tbName.Text = fileHtml.Name;
            tbPath.Text = fileHtml.Path;
            newFile = cbNewFile.Checked;

        }

        private void btOpenFileDialog_Click(object sender, EventArgs e) {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "|*.html";

            //Quero criar um ficheiro novo
            if (newFile)
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    tbPath.Text = Path.GetFullPath(sfd.FileName);
                }
                else
                {
                    MessageBox.Show("Não foi possivel encontrar o caminho do ficheiro!");
                }
            }                        
        }

        private void btSave_Click(object sender, EventArgs e) {
            fileHtml.Name = tbName.Text;
            fileHtml.Path = tbPath.Text;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btCancel_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void cbNewFile_CheckedChanged(object sender, EventArgs e)
        {
            newFile = cbNewFile.Checked;
            if (newFile)
            {
                tbPath.Enabled = true;
                btOpenFileDialog.Enabled = true;
            }
            else
            {
                tbPath.Enabled = false;
                btOpenFileDialog.Enabled = false;
            }
        }

        private void cbNewFile_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(cbNewFile, "Ao selecionar esta opção, vai ser criado um novo ficheiro e apagar o anterior em vez de reescrever o ficheiro existente");
        }
    }
}
