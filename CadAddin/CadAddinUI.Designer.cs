namespace CadAddin
{
    partial class CadAddinUI
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTextStyleCount = new System.Windows.Forms.Label();
            this.lblLineTypeCount = new System.Windows.Forms.Label();
            this.lblLayerCount = new System.Windows.Forms.Label();
            this.lstTextStyle = new System.Windows.Forms.ListBox();
            this.lstLineType = new System.Windows.Forms.ListBox();
            this.lstLayer = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtItemDisplay = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblFileName = new System.Windows.Forms.Label();
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.cboOptions = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.lblTextStyleCount);
            this.groupBox2.Controls.Add(this.lblLineTypeCount);
            this.groupBox2.Controls.Add(this.lblLayerCount);
            this.groupBox2.Controls.Add(this.lstTextStyle);
            this.groupBox2.Controls.Add(this.lstLineType);
            this.groupBox2.Controls.Add(this.lstLayer);
            this.groupBox2.Location = new System.Drawing.Point(263, 11);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(408, 433);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Display Container";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(267, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Text Style(s)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(144, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Line Type(s)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Layer(s)";
            // 
            // lblTextStyleCount
            // 
            this.lblTextStyleCount.AutoSize = true;
            this.lblTextStyleCount.Location = new System.Drawing.Point(256, 362);
            this.lblTextStyleCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTextStyleCount.Name = "lblTextStyleCount";
            this.lblTextStyleCount.Size = new System.Drawing.Size(16, 13);
            this.lblTextStyleCount.TabIndex = 5;
            this.lblTextStyleCount.Text = "...";
            // 
            // lblLineTypeCount
            // 
            this.lblLineTypeCount.AutoSize = true;
            this.lblLineTypeCount.Location = new System.Drawing.Point(133, 362);
            this.lblLineTypeCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLineTypeCount.Name = "lblLineTypeCount";
            this.lblLineTypeCount.Size = new System.Drawing.Size(16, 13);
            this.lblLineTypeCount.TabIndex = 4;
            this.lblLineTypeCount.Text = "...";
            // 
            // lblLayerCount
            // 
            this.lblLayerCount.AutoSize = true;
            this.lblLayerCount.Location = new System.Drawing.Point(10, 362);
            this.lblLayerCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLayerCount.Name = "lblLayerCount";
            this.lblLayerCount.Size = new System.Drawing.Size(16, 13);
            this.lblLayerCount.TabIndex = 3;
            this.lblLayerCount.Text = "...";
            // 
            // lstTextStyle
            // 
            this.lstTextStyle.FormattingEnabled = true;
            this.lstTextStyle.Location = new System.Drawing.Point(236, 53);
            this.lstTextStyle.Margin = new System.Windows.Forms.Padding(2);
            this.lstTextStyle.Name = "lstTextStyle";
            this.lstTextStyle.Size = new System.Drawing.Size(136, 303);
            this.lstTextStyle.TabIndex = 2;
            // 
            // lstLineType
            // 
            this.lstLineType.FormattingEnabled = true;
            this.lstLineType.Location = new System.Drawing.Point(128, 53);
            this.lstLineType.Margin = new System.Windows.Forms.Padding(2);
            this.lstLineType.Name = "lstLineType";
            this.lstLineType.Size = new System.Drawing.Size(104, 303);
            this.lstLineType.TabIndex = 1;
            // 
            // lstLayer
            // 
            this.lstLayer.FormattingEnabled = true;
            this.lstLayer.Location = new System.Drawing.Point(12, 53);
            this.lstLayer.Margin = new System.Windows.Forms.Padding(2);
            this.lstLayer.Name = "lstLayer";
            this.lstLayer.Size = new System.Drawing.Size(112, 303);
            this.lstLayer.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtItemDisplay);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblFileName);
            this.groupBox1.Controls.Add(this.btnSelectFile);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnClearAll);
            this.groupBox1.Controls.Add(this.btnDisplay);
            this.groupBox1.Controls.Add(this.cboOptions);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(6, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(254, 433);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options Container";
            // 
            // txtItemDisplay
            // 
            this.txtItemDisplay.Location = new System.Drawing.Point(130, 107);
            this.txtItemDisplay.Margin = new System.Windows.Forms.Padding(2);
            this.txtItemDisplay.Name = "txtItemDisplay";
            this.txtItemDisplay.Size = new System.Drawing.Size(114, 20);
            this.txtItemDisplay.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 110);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Enter Item to Diplay:";
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Location = new System.Drawing.Point(164, 33);
            this.lblFileName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(64, 13);
            this.lblFileName.TabIndex = 6;
            this.lblFileName.Text = "File name... ";
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.Location = new System.Drawing.Point(84, 27);
            this.btnSelectFile.Margin = new System.Windows.Forms.Padding(2);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(64, 22);
            this.btnSelectFile.TabIndex = 5;
            this.btnSelectFile.Text = "Select";
            this.btnSelectFile.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Select File:";
            // 
            // btnClearAll
            // 
            this.btnClearAll.Location = new System.Drawing.Point(115, 389);
            this.btnClearAll.Margin = new System.Windows.Forms.Padding(2);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(76, 29);
            this.btnClearAll.TabIndex = 3;
            this.btnClearAll.Text = "Clear all";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(17, 389);
            this.btnDisplay.Margin = new System.Windows.Forms.Padding(2);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(76, 29);
            this.btnDisplay.TabIndex = 2;
            this.btnDisplay.Text = "Show Items";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // cboOptions
            // 
            this.cboOptions.FormattingEnabled = true;
            this.cboOptions.Items.AddRange(new object[] {
            "All",
            "Layer",
            "LineType",
            "Textstyle"});
            this.cboOptions.Location = new System.Drawing.Point(130, 59);
            this.cboOptions.Margin = new System.Windows.Forms.Padding(2);
            this.cboOptions.Name = "cboOptions";
            this.cboOptions.Size = new System.Drawing.Size(114, 21);
            this.cboOptions.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 61);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Item to Display:";
            // 
            // CadAddinUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "CadAddinUI";
            this.Text = "CadAddinUI";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTextStyleCount;
        private System.Windows.Forms.Label lblLineTypeCount;
        private System.Windows.Forms.Label lblLayerCount;
        private System.Windows.Forms.ListBox lstTextStyle;
        private System.Windows.Forms.ListBox lstLineType;
        private System.Windows.Forms.ListBox lstLayer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtItemDisplay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.Button btnSelectFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.ComboBox cboOptions;
        private System.Windows.Forms.Label label1;
    }
}