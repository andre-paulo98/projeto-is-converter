namespace DataSourcesConverter.Components.Input.APIRest
{
    partial class FormApiRest
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
            this.tb_url.Location = new System.Drawing.Point(16, 36);
            this.tb_url.Margin = new System.Windows.Forms.Padding(4);
            this.tb_url.Name = "tb_url";
            this.tb_url.Size = new System.Drawing.Size(397, 22);
            this.tb_url.TabIndex = 0;
            // 
            // bt_request
            // 
            this.bt_request.Location = new System.Drawing.Point(423, 32);
            this.bt_request.Margin = new System.Windows.Forms.Padding(4);
            this.bt_request.Name = "bt_request";
            this.bt_request.Size = new System.Drawing.Size(112, 28);
            this.bt_request.TabIndex = 1;
            this.bt_request.Text = "Request Data";
            this.bt_request.UseVisualStyleBackColor = true;
            this.bt_request.Click += new System.EventHandler(this.bt_request_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Url:";
            // 
            // rtb_result
            // 
            this.rtb_result.Cursor = System.Windows.Forms.Cursors.Default;
            this.rtb_result.Location = new System.Drawing.Point(16, 94);
            this.rtb_result.Margin = new System.Windows.Forms.Padding(4);
            this.rtb_result.Name = "rtb_result";
            this.rtb_result.ReadOnly = true;
            this.rtb_result.Size = new System.Drawing.Size(517, 139);
            this.rtb_result.TabIndex = 4;
            this.rtb_result.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Result:";
            // 
            // bt_save
            // 
            this.bt_save.Location = new System.Drawing.Point(435, 241);
            this.bt_save.Margin = new System.Windows.Forms.Padding(4);
            this.bt_save.Name = "bt_save";
            this.bt_save.Size = new System.Drawing.Size(100, 28);
            this.bt_save.TabIndex = 7;
            this.bt_save.Text = "Save";
            this.bt_save.UseVisualStyleBackColor = true;
            this.bt_save.Click += new System.EventHandler(this.bt_save_Click);
            // 
            // bt_cancel
            // 
            this.bt_cancel.Location = new System.Drawing.Point(325, 241);
            this.bt_cancel.Margin = new System.Windows.Forms.Padding(4);
            this.bt_cancel.Name = "bt_cancel";
            this.bt_cancel.Size = new System.Drawing.Size(100, 28);
            this.bt_cancel.TabIndex = 8;
            this.bt_cancel.Text = "Cancel";
            this.bt_cancel.UseVisualStyleBackColor = true;
            // 
            // FormApiRest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 286);
            this.Controls.Add(this.bt_cancel);
            this.Controls.Add(this.bt_save);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rtb_result);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_request);
            this.Controls.Add(this.tb_url);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormApiRest";
            this.Text = "FormApiRest";
            this.Load += new System.EventHandler(this.FormApiRest_Load);
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