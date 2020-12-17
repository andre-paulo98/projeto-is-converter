
namespace dummy_MQTTPublisher {
    partial class Publisher {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Publisher));
            this.label3 = new System.Windows.Forms.Label();
            this.btConnect = new System.Windows.Forms.Button();
            this.tbHost = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbMessage = new System.Windows.Forms.TextBox();
            this.btPublish = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbTopic = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(132, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 24);
            this.label3.TabIndex = 16;
            this.label3.Text = "** PUBLISHER **";
            // 
            // btConnect
            // 
            this.btConnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btConnect.Location = new System.Drawing.Point(321, 36);
            this.btConnect.Name = "btConnect";
            this.btConnect.Size = new System.Drawing.Size(98, 28);
            this.btConnect.TabIndex = 15;
            this.btConnect.Text = "Connect";
            this.btConnect.UseVisualStyleBackColor = true;
            this.btConnect.Click += new System.EventHandler(this.btConnect_Click);
            // 
            // tbHost
            // 
            this.tbHost.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbHost.Location = new System.Drawing.Point(69, 37);
            this.tbHost.Name = "tbHost";
            this.tbHost.Size = new System.Drawing.Size(246, 26);
            this.tbHost.TabIndex = 14;
            this.tbHost.Text = "127.0.0.1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Broker:";
            // 
            // tbMessage
            // 
            this.tbMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMessage.Enabled = false;
            this.tbMessage.Location = new System.Drawing.Point(15, 105);
            this.tbMessage.Multiline = true;
            this.tbMessage.Name = "tbMessage";
            this.tbMessage.Size = new System.Drawing.Size(403, 162);
            this.tbMessage.TabIndex = 12;
            // 
            // btPublish
            // 
            this.btPublish.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btPublish.Enabled = false;
            this.btPublish.Location = new System.Drawing.Point(15, 274);
            this.btPublish.Margin = new System.Windows.Forms.Padding(4);
            this.btPublish.Name = "btPublish";
            this.btPublish.Size = new System.Drawing.Size(405, 28);
            this.btPublish.TabIndex = 11;
            this.btPublish.Text = "Publish";
            this.btPublish.UseVisualStyleBackColor = true;
            this.btPublish.Click += new System.EventHandler(this.btPublish_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 73);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Topic:";
            // 
            // tbTopic
            // 
            this.tbTopic.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTopic.Enabled = false;
            this.tbTopic.Location = new System.Drawing.Point(69, 70);
            this.tbTopic.Name = "tbTopic";
            this.tbTopic.Size = new System.Drawing.Size(349, 26);
            this.tbTopic.TabIndex = 17;
            this.tbTopic.Text = "message";
            // 
            // Publisher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 315);
            this.Controls.Add(this.tbTopic);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btConnect);
            this.Controls.Add(this.tbHost);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbMessage);
            this.Controls.Add(this.btPublish);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(283, 239);
            this.Name = "Publisher";
            this.Text = "Publisher";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Publisher_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btConnect;
        private System.Windows.Forms.TextBox tbHost;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbMessage;
        private System.Windows.Forms.Button btPublish;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbTopic;
    }
}

