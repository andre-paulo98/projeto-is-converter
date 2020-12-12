namespace DataSourcesConverter.Components.Output.APIRest
{
    partial class FormApiRestOutput
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
            this.tbName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbMethod = new System.Windows.Forms.ComboBox();
            this.bt_cancel = new System.Windows.Forms.Button();
            this.bt_save = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.rtb_result = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_request = new System.Windows.Forms.Button();
            this.tb_url = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbName
            // 
            this.tbName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbName.Location = new System.Drawing.Point(9, 62);
            this.tbName.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(734, 30);
            this.tbName.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 23);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 25);
            this.label4.TabIndex = 22;
            this.label4.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 203);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 25);
            this.label3.TabIndex = 21;
            this.label3.Text = "Método:";
            // 
            // cbMethod
            // 
            this.cbMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMethod.FormattingEnabled = true;
            this.cbMethod.Items.AddRange(new object[] {
            "GET",
            "POST",
            "PUT",
            "DELETE",
            "PATCH"});
            this.cbMethod.Location = new System.Drawing.Point(9, 241);
            this.cbMethod.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.cbMethod.Name = "cbMethod";
            this.cbMethod.Size = new System.Drawing.Size(334, 33);
            this.cbMethod.TabIndex = 16;
            // 
            // bt_cancel
            // 
            this.bt_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_cancel.Location = new System.Drawing.Point(394, 513);
            this.bt_cancel.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.bt_cancel.Name = "bt_cancel";
            this.bt_cancel.Size = new System.Drawing.Size(168, 55);
            this.bt_cancel.TabIndex = 19;
            this.bt_cancel.Text = "Cancelar";
            this.bt_cancel.UseVisualStyleBackColor = true;
            // 
            // bt_save
            // 
            this.bt_save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_save.Enabled = false;
            this.bt_save.Location = new System.Drawing.Point(576, 513);
            this.bt_save.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.bt_save.Name = "bt_save";
            this.bt_save.Size = new System.Drawing.Size(168, 55);
            this.bt_save.TabIndex = 20;
            this.bt_save.Text = "Guardar";
            this.bt_save.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 298);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 25);
            this.label2.TabIndex = 18;
            this.label2.Text = "Resultado:";
            // 
            // rtb_result
            // 
            this.rtb_result.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtb_result.Cursor = System.Windows.Forms.Cursors.Default;
            this.rtb_result.Location = new System.Drawing.Point(-1, 343);
            this.rtb_result.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.rtb_result.Name = "rtb_result";
            this.rtb_result.ReadOnly = true;
            this.rtb_result.Size = new System.Drawing.Size(740, 154);
            this.rtb_result.TabIndex = 17;
            this.rtb_result.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 109);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Link:";
            // 
            // bt_request
            // 
            this.bt_request.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_request.Location = new System.Drawing.Point(556, 142);
            this.bt_request.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.bt_request.Name = "bt_request";
            this.bt_request.Size = new System.Drawing.Size(189, 55);
            this.bt_request.TabIndex = 15;
            this.bt_request.Text = "Obter Dados";
            this.bt_request.UseVisualStyleBackColor = true;
            // 
            // tb_url
            // 
            this.tb_url.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_url.Location = new System.Drawing.Point(9, 147);
            this.tb_url.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.tb_url.Name = "tb_url";
            this.tb_url.Size = new System.Drawing.Size(527, 30);
            this.tb_url.TabIndex = 13;
            // 
            // FormApiRestOutput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 591);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbMethod);
            this.Controls.Add(this.bt_cancel);
            this.Controls.Add(this.bt_save);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rtb_result);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_request);
            this.Controls.Add(this.tb_url);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormApiRestOutput";
            this.Text = "FormApiRestOutput";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbMethod;
        private System.Windows.Forms.Button bt_cancel;
        private System.Windows.Forms.Button bt_save;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rtb_result;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_request;
        private System.Windows.Forms.TextBox tb_url;
    }
}