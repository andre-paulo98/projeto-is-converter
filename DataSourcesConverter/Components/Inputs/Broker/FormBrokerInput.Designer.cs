namespace DataSourcesConverter.Components.Inputs.Broker
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbHost = new System.Windows.Forms.TextBox();
            this.lboxTopics = new System.Windows.Forms.ListBox();
            this.btSave = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.gbListTopics = new System.Windows.Forms.GroupBox();
            this.btConnect = new System.Windows.Forms.Button();
            this.tbTopic = new System.Windows.Forms.TextBox();
            this.btRemove = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.gbListTopics.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Endereço IP:";
            // 
            // tbHost
            // 
            this.tbHost.Location = new System.Drawing.Point(12, 25);
            this.tbHost.Name = "tbHost";
            this.tbHost.Size = new System.Drawing.Size(209, 20);
            this.tbHost.TabIndex = 1;
            // 
            // lboxTopics
            // 
            this.lboxTopics.FormattingEnabled = true;
            this.lboxTopics.Location = new System.Drawing.Point(6, 68);
            this.lboxTopics.Name = "lboxTopics";
            this.lboxTopics.Size = new System.Drawing.Size(271, 121);
            this.lboxTopics.TabIndex = 2;
            this.lboxTopics.SelectedIndexChanged += new System.EventHandler(this.lboxTopics_SelectedIndexChanged);
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(227, 284);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(75, 23);
            this.btSave.TabIndex = 7;
            this.btSave.Text = "Guardar";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(133, 284);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 8;
            this.btCancel.Text = "Cancelar";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // gbListTopics
            // 
            this.gbListTopics.Controls.Add(this.label2);
            this.gbListTopics.Controls.Add(this.btAdd);
            this.gbListTopics.Controls.Add(this.tbTopic);
            this.gbListTopics.Controls.Add(this.btRemove);
            this.gbListTopics.Controls.Add(this.lboxTopics);
            this.gbListTopics.Enabled = false;
            this.gbListTopics.Location = new System.Drawing.Point(12, 51);
            this.gbListTopics.Name = "gbListTopics";
            this.gbListTopics.Size = new System.Drawing.Size(290, 227);
            this.gbListTopics.TabIndex = 10;
            this.gbListTopics.TabStop = false;
            this.gbListTopics.Text = "Lista de Topicos:";
            // 
            // btConnect
            // 
            this.btConnect.Location = new System.Drawing.Point(227, 23);
            this.btConnect.Name = "btConnect";
            this.btConnect.Size = new System.Drawing.Size(75, 23);
            this.btConnect.TabIndex = 11;
            this.btConnect.Text = "Conectar";
            this.btConnect.UseVisualStyleBackColor = true;
            this.btConnect.Click += new System.EventHandler(this.btConnect_Click);
            // 
            // tbTopic
            // 
            this.tbTopic.Location = new System.Drawing.Point(8, 41);
            this.tbTopic.Name = "tbTopic";
            this.tbTopic.Size = new System.Drawing.Size(188, 20);
            this.tbTopic.TabIndex = 8;
            // 
            // btRemove
            // 
            this.btRemove.Location = new System.Drawing.Point(192, 195);
            this.btRemove.Name = "btRemove";
            this.btRemove.Size = new System.Drawing.Size(85, 23);
            this.btRemove.TabIndex = 10;
            this.btRemove.Text = "Remover";
            this.btRemove.UseVisualStyleBackColor = true;
            this.btRemove.Click += new System.EventHandler(this.btRemove_Click);
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(202, 39);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(75, 23);
            this.btAdd.TabIndex = 9;
            this.btAdd.Text = "Adicionar";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.tbAdd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Topico:";
            // 
            // FormBrokerInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 316);
            this.Controls.Add(this.btConnect);
            this.Controls.Add(this.gbListTopics);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.tbHost);
            this.Controls.Add(this.label1);
            this.Name = "FormBrokerInput";
            this.Text = "FormBrokerInput";
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
    }
}