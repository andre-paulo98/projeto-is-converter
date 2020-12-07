﻿namespace DataSourcesConverter.Components.Inputs.APIRest {
    partial class FormApiRest {


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
            this.tb_url = new System.Windows.Forms.TextBox();
            this.bt_request = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.rtb_result = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_save = new System.Windows.Forms.Button();
            this.bt_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_url
            // 
            this.tb_url.Location = new System.Drawing.Point(12, 29);
            this.tb_url.Name = "tb_url";
            this.tb_url.Size = new System.Drawing.Size(299, 20);
            this.tb_url.TabIndex = 0;
            // 
            // bt_request
            // 
            this.bt_request.Location = new System.Drawing.Point(317, 26);
            this.bt_request.Name = "bt_request";
            this.bt_request.Size = new System.Drawing.Size(84, 23);
            this.bt_request.TabIndex = 1;
            this.bt_request.Text = "Request Data";
            this.bt_request.UseVisualStyleBackColor = true;
            this.bt_request.Click += new System.EventHandler(this.bt_request_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Url:";
            // 
            // rtb_result
            // 
            this.rtb_result.Cursor = System.Windows.Forms.Cursors.Default;
            this.rtb_result.Location = new System.Drawing.Point(12, 76);
            this.rtb_result.Name = "rtb_result";
            this.rtb_result.ReadOnly = true;
            this.rtb_result.Size = new System.Drawing.Size(389, 114);
            this.rtb_result.TabIndex = 4;
            this.rtb_result.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Result:";
            // 
            // bt_save
            // 
            this.bt_save.Enabled = false;
            this.bt_save.Location = new System.Drawing.Point(326, 196);
            this.bt_save.Name = "bt_save";
            this.bt_save.Size = new System.Drawing.Size(75, 23);
            this.bt_save.TabIndex = 7;
            this.bt_save.Text = "Save";
            this.bt_save.UseVisualStyleBackColor = true;
            this.bt_save.Click += new System.EventHandler(this.bt_save_Click);
            // 
            // bt_cancel
            // 
            this.bt_cancel.Location = new System.Drawing.Point(244, 196);
            this.bt_cancel.Name = "bt_cancel";
            this.bt_cancel.Size = new System.Drawing.Size(75, 23);
            this.bt_cancel.TabIndex = 8;
            this.bt_cancel.Text = "Cancel";
            this.bt_cancel.UseVisualStyleBackColor = true;
            this.bt_cancel.Click += new System.EventHandler(this.bt_cancel_Click);
            // 
            // FormApiRest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 232);
            this.Controls.Add(this.bt_cancel);
            this.Controls.Add(this.bt_save);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rtb_result);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_request);
            this.Controls.Add(this.tb_url);
            this.Name = "FormApiRest";
            this.Text = "FormApiRest";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_url;
        private System.Windows.Forms.Button bt_request;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtb_result;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt_save;
        private System.Windows.Forms.Button bt_cancel;
    }
}