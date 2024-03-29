﻿namespace DataSourcesConverter.Components.Inputs.Broker
{
    partial class FormBrokerInput
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBrokerInput));
            this.label1 = new System.Windows.Forms.Label();
            this.tbHost = new System.Windows.Forms.TextBox();
            this.lboxTopics = new System.Windows.Forms.ListBox();
            this.btSave = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.gbListTopics = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btAdd = new System.Windows.Forms.Button();
            this.tbTopic = new System.Windows.Forms.TextBox();
            this.btRemove = new System.Windows.Forms.Button();
            this.btConnect = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.gbListTopics.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 74);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Endereço IP:";
            // 
            // tbHost
            // 
            this.tbHost.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbHost.Location = new System.Drawing.Point(18, 98);
            this.tbHost.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbHost.Name = "tbHost";
            this.tbHost.Size = new System.Drawing.Size(253, 26);
            this.tbHost.TabIndex = 2;
            // 
            // lboxTopics
            // 
            this.lboxTopics.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lboxTopics.FormattingEnabled = true;
            this.lboxTopics.ItemHeight = 20;
            this.lboxTopics.Location = new System.Drawing.Point(9, 105);
            this.lboxTopics.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lboxTopics.Name = "lboxTopics";
            this.lboxTopics.Size = new System.Drawing.Size(345, 144);
            this.lboxTopics.TabIndex = 6;
            this.lboxTopics.SelectedIndexChanged += new System.EventHandler(this.lboxTopics_SelectedIndexChanged);
            // 
            // btSave
            // 
            this.btSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btSave.Enabled = false;
            this.btSave.Location = new System.Drawing.Point(281, 451);
            this.btSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(112, 35);
            this.btSave.TabIndex = 12;
            this.btSave.Text = "Guardar";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btCancel
            // 
            this.btCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btCancel.Location = new System.Drawing.Point(159, 451);
            this.btCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(112, 35);
            this.btCancel.TabIndex = 11;
            this.btCancel.Text = "Cancelar";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // gbListTopics
            // 
            this.gbListTopics.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbListTopics.Controls.Add(this.label2);
            this.gbListTopics.Controls.Add(this.btAdd);
            this.gbListTopics.Controls.Add(this.tbTopic);
            this.gbListTopics.Controls.Add(this.btRemove);
            this.gbListTopics.Controls.Add(this.lboxTopics);
            this.gbListTopics.Enabled = false;
            this.gbListTopics.Location = new System.Drawing.Point(18, 132);
            this.gbListTopics.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbListTopics.Name = "gbListTopics";
            this.gbListTopics.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbListTopics.Size = new System.Drawing.Size(376, 309);
            this.gbListTopics.TabIndex = 10;
            this.gbListTopics.TabStop = false;
            this.gbListTopics.Text = "Lista de Tópicos:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 38);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Tópico:";
            // 
            // btAdd
            // 
            this.btAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btAdd.Location = new System.Drawing.Point(244, 60);
            this.btAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(112, 35);
            this.btAdd.TabIndex = 5;
            this.btAdd.Text = "Adicionar";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.tbAdd_Click);
            // 
            // tbTopic
            // 
            this.tbTopic.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTopic.Location = new System.Drawing.Point(12, 63);
            this.tbTopic.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbTopic.Name = "tbTopic";
            this.tbTopic.Size = new System.Drawing.Size(221, 26);
            this.tbTopic.TabIndex = 4;
            // 
            // btRemove
            // 
            this.btRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btRemove.Enabled = false;
            this.btRemove.Location = new System.Drawing.Point(229, 260);
            this.btRemove.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btRemove.Name = "btRemove";
            this.btRemove.Size = new System.Drawing.Size(128, 35);
            this.btRemove.TabIndex = 10;
            this.btRemove.Text = "Remover";
            this.btRemove.UseVisualStyleBackColor = true;
            this.btRemove.Click += new System.EventHandler(this.btRemove_Click);
            // 
            // btConnect
            // 
            this.btConnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btConnect.Location = new System.Drawing.Point(281, 95);
            this.btConnect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btConnect.Name = "btConnect";
            this.btConnect.Size = new System.Drawing.Size(112, 35);
            this.btConnect.TabIndex = 3;
            this.btConnect.Text = "Conectar";
            this.btConnect.UseVisualStyleBackColor = true;
            this.btConnect.Click += new System.EventHandler(this.btConnect_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Nome:";
            // 
            // tbName
            // 
            this.tbName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbName.Location = new System.Drawing.Point(18, 37);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(375, 26);
            this.tbName.TabIndex = 1;
            // 
            // FormBrokerInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 504);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btConnect);
            this.Controls.Add(this.gbListTopics);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.tbHost);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(301, 450);
            this.Name = "FormBrokerInput";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ler de sistema de mensagens";
            this.gbListTopics.ResumeLayout(false);
            this.gbListTopics.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbHost;
        private System.Windows.Forms.ListBox lboxTopics;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.GroupBox gbListTopics;
        private System.Windows.Forms.Button btConnect;
        private System.Windows.Forms.TextBox tbTopic;
        private System.Windows.Forms.Button btRemove;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbName;
    }
}