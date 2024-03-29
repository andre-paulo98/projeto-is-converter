﻿
namespace DataSourcesConverter {
    partial class FormHome {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHome));
            this.flowsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panelFirstItemFlowLayout = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importarXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportarXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.executarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rtbLog = new System.Windows.Forms.RichTextBox();
            this.btClearLog = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.flowsPanel.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowsPanel
            // 
            this.flowsPanel.AutoScroll = true;
            this.flowsPanel.Controls.Add(this.panelFirstItemFlowLayout);
            this.flowsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowsPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowsPanel.Location = new System.Drawing.Point(0, 0);
            this.flowsPanel.Name = "flowsPanel";
            this.flowsPanel.Size = new System.Drawing.Size(700, 462);
            this.flowsPanel.TabIndex = 0;
            this.flowsPanel.WrapContents = false;
            this.flowsPanel.SizeChanged += new System.EventHandler(this.flowLayoutPanel1_SizeChanged);
            // 
            // panelFirstItemFlowLayout
            // 
            this.panelFirstItemFlowLayout.BackColor = System.Drawing.SystemColors.Control;
            this.panelFirstItemFlowLayout.Location = new System.Drawing.Point(0, 0);
            this.panelFirstItemFlowLayout.Margin = new System.Windows.Forms.Padding(0);
            this.panelFirstItemFlowLayout.Name = "panelFirstItemFlowLayout";
            this.panelFirstItemFlowLayout.Size = new System.Drawing.Size(1, 1);
            this.panelFirstItemFlowLayout.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dadosToolStripMenuItem,
            this.executarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1064, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dadosToolStripMenuItem
            // 
            this.dadosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importarXMLToolStripMenuItem,
            this.exportarXMLToolStripMenuItem});
            this.dadosToolStripMenuItem.Name = "dadosToolStripMenuItem";
            this.dadosToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.dadosToolStripMenuItem.Text = "Dados";
            // 
            // importarXMLToolStripMenuItem
            // 
            this.importarXMLToolStripMenuItem.Name = "importarXMLToolStripMenuItem";
            this.importarXMLToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.importarXMLToolStripMenuItem.Text = "Importar XML...";
            this.importarXMLToolStripMenuItem.Click += new System.EventHandler(this.importarXMLToolStripMenuItem_Click);
            // 
            // exportarXMLToolStripMenuItem
            // 
            this.exportarXMLToolStripMenuItem.Name = "exportarXMLToolStripMenuItem";
            this.exportarXMLToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exportarXMLToolStripMenuItem.Text = "Exportar XML...";
            this.exportarXMLToolStripMenuItem.Click += new System.EventHandler(this.exportarXMLToolStripMenuItem_Click);
            // 
            // executarToolStripMenuItem
            // 
            this.executarToolStripMenuItem.Name = "executarToolStripMenuItem";
            this.executarToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.executarToolStripMenuItem.Text = "Executar";
            this.executarToolStripMenuItem.Click += new System.EventHandler(this.executarToolStripMenuItem_Click);
            // 
            // rtbLog
            // 
            this.rtbLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbLog.Location = new System.Drawing.Point(3, 3);
            this.rtbLog.Name = "rtbLog";
            this.rtbLog.Size = new System.Drawing.Size(347, 422);
            this.rtbLog.TabIndex = 2;
            this.rtbLog.Text = "";
            // 
            // btClearLog
            // 
            this.btClearLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btClearLog.Location = new System.Drawing.Point(206, 431);
            this.btClearLog.Name = "btClearLog";
            this.btClearLog.Size = new System.Drawing.Size(148, 28);
            this.btClearLog.TabIndex = 3;
            this.btClearLog.Text = "Limpar mensagens";
            this.btClearLog.UseVisualStyleBackColor = true;
            this.btClearLog.Click += new System.EventHandler(this.btClearLog_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.flowsPanel);
            this.splitContainer1.Panel1MinSize = 700;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.rtbLog);
            this.splitContainer1.Panel2.Controls.Add(this.btClearLog);
            this.splitContainer1.Size = new System.Drawing.Size(1064, 462);
            this.splitContainer1.SplitterDistance = 700;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 4;
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "Ficheiros XML|*.xml";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.Filter = "Ficheiros XML|*.xml";
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 486);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1080, 525);
            this.Name = "FormHome";
            this.Text = "Converter";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormHome_FormClosing);
            this.Load += new System.EventHandler(this.FormHome_Load);
            this.flowsPanel.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowsPanel;
        private System.Windows.Forms.Panel panelFirstItemFlowLayout;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importarXMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportarXMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem executarToolStripMenuItem;
        private System.Windows.Forms.RichTextBox rtbLog;
        private System.Windows.Forms.Button btClearLog;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}

