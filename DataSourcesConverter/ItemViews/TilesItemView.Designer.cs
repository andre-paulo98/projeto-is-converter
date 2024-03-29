﻿
namespace DataSourcesConverter.ItemViews {
    partial class TilesItemView {
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btSetInput = new System.Windows.Forms.Button();
            this.groupBoxInput = new System.Windows.Forms.GroupBox();
            this.lblNameInput = new System.Windows.Forms.Label();
            this.lblTypeInput = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelOutput = new System.Windows.Forms.Panel();
            this.btSetOutput = new System.Windows.Forms.Button();
            this.groupBoxOutput = new System.Windows.Forms.GroupBox();
            this.lblNameOutput = new System.Windows.Forms.Label();
            this.lblTypeOutput = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btEditInput = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btDelete = new System.Windows.Forms.Button();
            this.btRun = new System.Windows.Forms.Button();
            this.btEditOutput = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBoxInput.SuspendLayout();
            this.panelOutput.SuspendLayout();
            this.groupBoxOutput.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelOutput, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(642, 92);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btSetInput);
            this.panel1.Controls.Add(this.groupBoxInput);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(65, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(243, 92);
            this.panel1.TabIndex = 4;
            // 
            // btSetInput
            // 
            this.btSetInput.Dock = System.Windows.Forms.DockStyle.Right;
            this.btSetInput.Location = new System.Drawing.Point(233, 0);
            this.btSetInput.Name = "btSetInput";
            this.btSetInput.Size = new System.Drawing.Size(10, 92);
            this.btSetInput.TabIndex = 4;
            this.btSetInput.Text = "Definir Input";
            this.btSetInput.UseVisualStyleBackColor = true;
            this.btSetInput.Click += new System.EventHandler(this.SetInput_Click);
            // 
            // groupBoxInput
            // 
            this.groupBoxInput.Controls.Add(this.btEditInput);
            this.groupBoxInput.Controls.Add(this.lblNameInput);
            this.groupBoxInput.Controls.Add(this.lblTypeInput);
            this.groupBoxInput.Controls.Add(this.label2);
            this.groupBoxInput.Controls.Add(this.label1);
            this.groupBoxInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxInput.Location = new System.Drawing.Point(0, 0);
            this.groupBoxInput.Margin = new System.Windows.Forms.Padding(1);
            this.groupBoxInput.Name = "groupBoxInput";
            this.groupBoxInput.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxInput.Size = new System.Drawing.Size(243, 92);
            this.groupBoxInput.TabIndex = 1;
            this.groupBoxInput.TabStop = false;
            this.groupBoxInput.Text = "Input";
            // 
            // lblNameInput
            // 
            this.lblNameInput.AutoSize = true;
            this.lblNameInput.Location = new System.Drawing.Point(69, 58);
            this.lblNameInput.Name = "lblNameInput";
            this.lblNameInput.Size = new System.Drawing.Size(113, 20);
            this.lblNameInput.TabIndex = 3;
            this.lblNameInput.Text = "{lblNameInput}";
            this.lblNameInput.Click += new System.EventHandler(this.SetInput_Click);
            // 
            // lblTypeInput
            // 
            this.lblTypeInput.AutoSize = true;
            this.lblTypeInput.Location = new System.Drawing.Point(57, 24);
            this.lblTypeInput.Name = "lblTypeInput";
            this.lblTypeInput.Size = new System.Drawing.Size(105, 20);
            this.lblTypeInput.TabIndex = 2;
            this.lblTypeInput.Text = "{lblTypeInput}";
            this.lblTypeInput.Click += new System.EventHandler(this.SetInput_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome:";
            this.label2.Click += new System.EventHandler(this.SetInput_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo:";
            this.label1.Click += new System.EventHandler(this.SetInput_Click);
            // 
            // panelOutput
            // 
            this.panelOutput.Controls.Add(this.btSetOutput);
            this.panelOutput.Controls.Add(this.groupBoxOutput);
            this.panelOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOutput.Enabled = false;
            this.panelOutput.Location = new System.Drawing.Point(398, 0);
            this.panelOutput.Margin = new System.Windows.Forms.Padding(0);
            this.panelOutput.Name = "panelOutput";
            this.panelOutput.Size = new System.Drawing.Size(244, 92);
            this.panelOutput.TabIndex = 5;
            // 
            // btSetOutput
            // 
            this.btSetOutput.Dock = System.Windows.Forms.DockStyle.Right;
            this.btSetOutput.Location = new System.Drawing.Point(234, 0);
            this.btSetOutput.Name = "btSetOutput";
            this.btSetOutput.Size = new System.Drawing.Size(10, 92);
            this.btSetOutput.TabIndex = 4;
            this.btSetOutput.Text = "Definir Output";
            this.btSetOutput.UseVisualStyleBackColor = true;
            this.btSetOutput.Click += new System.EventHandler(this.SetOutput_Click);
            // 
            // groupBoxOutput
            // 
            this.groupBoxOutput.Controls.Add(this.btEditOutput);
            this.groupBoxOutput.Controls.Add(this.lblNameOutput);
            this.groupBoxOutput.Controls.Add(this.lblTypeOutput);
            this.groupBoxOutput.Controls.Add(this.label3);
            this.groupBoxOutput.Controls.Add(this.label4);
            this.groupBoxOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOutput.Location = new System.Drawing.Point(0, 0);
            this.groupBoxOutput.Margin = new System.Windows.Forms.Padding(1);
            this.groupBoxOutput.Name = "groupBoxOutput";
            this.groupBoxOutput.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxOutput.Size = new System.Drawing.Size(244, 92);
            this.groupBoxOutput.TabIndex = 2;
            this.groupBoxOutput.TabStop = false;
            this.groupBoxOutput.Text = "Output";
            // 
            // lblNameOutput
            // 
            this.lblNameOutput.AutoSize = true;
            this.lblNameOutput.Location = new System.Drawing.Point(69, 58);
            this.lblNameOutput.Name = "lblNameOutput";
            this.lblNameOutput.Size = new System.Drawing.Size(125, 20);
            this.lblNameOutput.TabIndex = 3;
            this.lblNameOutput.Text = "{lblNameOutput}";
            this.lblNameOutput.Click += new System.EventHandler(this.SetOutput_Click);
            // 
            // lblTypeOutput
            // 
            this.lblTypeOutput.AutoSize = true;
            this.lblTypeOutput.Location = new System.Drawing.Point(57, 24);
            this.lblTypeOutput.Name = "lblTypeOutput";
            this.lblTypeOutput.Size = new System.Drawing.Size(117, 20);
            this.lblTypeOutput.TabIndex = 2;
            this.lblTypeOutput.Text = "{lblTypeOutput}";
            this.lblTypeOutput.Click += new System.EventHandler(this.SetOutput_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tipo:";
            this.label3.Click += new System.EventHandler(this.SetOutput_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Nome:";
            this.label4.Click += new System.EventHandler(this.SetOutput_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.btDelete, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btRun, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 3, 2, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(60, 86);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // btEditInput
            // 
            this.btEditInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btEditInput.BackgroundImage = global::DataSourcesConverter.Properties.Resources.edit;
            this.btEditInput.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btEditInput.Location = new System.Drawing.Point(188, 24);
            this.btEditInput.Name = "btEditInput";
            this.btEditInput.Size = new System.Drawing.Size(46, 45);
            this.btEditInput.TabIndex = 4;
            this.btEditInput.UseVisualStyleBackColor = true;
            this.btEditInput.Click += new System.EventHandler(this.btEditInput_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::DataSourcesConverter.Properties.Resources.right_arrow;
            this.pictureBox1.Location = new System.Drawing.Point(308, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 92);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btDelete
            // 
            this.btDelete.BackColor = System.Drawing.Color.Red;
            this.btDelete.BackgroundImage = global::DataSourcesConverter.Properties.Resources.delete_button;
            this.btDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btDelete.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDelete.Location = new System.Drawing.Point(0, 0);
            this.btDelete.Margin = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(60, 28);
            this.btDelete.TabIndex = 4;
            this.btDelete.UseVisualStyleBackColor = false;
            this.btDelete.Visible = false;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btRun
            // 
            this.btRun.BackColor = System.Drawing.Color.LimeGreen;
            this.btRun.BackgroundImage = global::DataSourcesConverter.Properties.Resources.run_button;
            this.btRun.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btRun.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btRun.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
            this.btRun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRun.Location = new System.Drawing.Point(0, 30);
            this.btRun.Margin = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.btRun.Name = "btRun";
            this.btRun.Size = new System.Drawing.Size(60, 56);
            this.btRun.TabIndex = 3;
            this.btRun.UseVisualStyleBackColor = false;
            this.btRun.Visible = false;
            this.btRun.Click += new System.EventHandler(this.btRun_Click);
            // 
            // btEditOutput
            // 
            this.btEditOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btEditOutput.BackgroundImage = global::DataSourcesConverter.Properties.Resources.edit;
            this.btEditOutput.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btEditOutput.Location = new System.Drawing.Point(191, 24);
            this.btEditOutput.Name = "btEditOutput";
            this.btEditOutput.Size = new System.Drawing.Size(46, 45);
            this.btEditOutput.TabIndex = 5;
            this.btEditOutput.UseVisualStyleBackColor = true;
            this.btEditOutput.Click += new System.EventHandler(this.btEditOutput_Click);
            // 
            // TilesItemView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(0, 92);
            this.MinimumSize = new System.Drawing.Size(642, 92);
            this.Name = "TilesItemView";
            this.Size = new System.Drawing.Size(642, 92);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBoxInput.ResumeLayout(false);
            this.groupBoxInput.PerformLayout();
            this.panelOutput.ResumeLayout(false);
            this.groupBoxOutput.ResumeLayout(false);
            this.groupBoxOutput.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBoxInput;
        private System.Windows.Forms.GroupBox groupBoxOutput;
        private System.Windows.Forms.Label lblNameInput;
        private System.Windows.Forms.Label lblTypeInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNameOutput;
        private System.Windows.Forms.Label lblTypeOutput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btRun;
        private System.Windows.Forms.Button btSetOutput;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btSetInput;
        private System.Windows.Forms.Panel panelOutput;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btEditInput;
        private System.Windows.Forms.Button btEditOutput;
    }
}
