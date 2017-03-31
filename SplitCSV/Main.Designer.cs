namespace SplitCSV
{
    partial class Main
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
            this.openCSVFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.btnSplitFile = new System.Windows.Forms.Button();
            this.lblFileSelected = new System.Windows.Forms.Label();
            this.lstOutputHeaders = new System.Windows.Forms.ListBox();
            this.btnMoveSelected = new System.Windows.Forms.Button();
            this.btnMoveLeft = new System.Windows.Forms.Button();
            this.lstHeaders = new System.Windows.Forms.ListBox();
            this.numNumberOfRows = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnMoveAll = new System.Windows.Forms.Button();
            this.btnMoveAllLeft = new System.Windows.Forms.Button();
            this.groupHeaders = new System.Windows.Forms.GroupBox();
            this.chkManageHeaders = new System.Windows.Forms.CheckBox();
            this.groupCalc = new System.Windows.Forms.GroupBox();
            this.lblCSVNo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numNumberOfRows)).BeginInit();
            this.groupHeaders.SuspendLayout();
            this.groupCalc.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of Items in each file:";
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.Location = new System.Drawing.Point(302, 12);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(92, 23);
            this.btnSelectFile.TabIndex = 1;
            this.btnSelectFile.Text = "Select File";
            this.btnSelectFile.UseVisualStyleBackColor = true;
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
            // 
            // btnSplitFile
            // 
            this.btnSplitFile.Enabled = false;
            this.btnSplitFile.Location = new System.Drawing.Point(400, 12);
            this.btnSplitFile.Name = "btnSplitFile";
            this.btnSplitFile.Size = new System.Drawing.Size(75, 23);
            this.btnSplitFile.TabIndex = 3;
            this.btnSplitFile.Text = "Split File";
            this.btnSplitFile.UseVisualStyleBackColor = true;
            this.btnSplitFile.Click += new System.EventHandler(this.btnSplitFile_Click);
            // 
            // lblFileSelected
            // 
            this.lblFileSelected.AutoSize = true;
            this.lblFileSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFileSelected.ForeColor = System.Drawing.Color.Blue;
            this.lblFileSelected.Location = new System.Drawing.Point(91, 56);
            this.lblFileSelected.Name = "lblFileSelected";
            this.lblFileSelected.Size = new System.Drawing.Size(0, 13);
            this.lblFileSelected.TabIndex = 5;
            // 
            // lstOutputHeaders
            // 
            this.lstOutputHeaders.FormattingEnabled = true;
            this.lstOutputHeaders.Location = new System.Drawing.Point(257, 39);
            this.lstOutputHeaders.Name = "lstOutputHeaders";
            this.lstOutputHeaders.Size = new System.Drawing.Size(120, 134);
            this.lstOutputHeaders.TabIndex = 6;
            // 
            // btnMoveSelected
            // 
            this.btnMoveSelected.Location = new System.Drawing.Point(167, 50);
            this.btnMoveSelected.Name = "btnMoveSelected";
            this.btnMoveSelected.Size = new System.Drawing.Size(75, 23);
            this.btnMoveSelected.TabIndex = 7;
            this.btnMoveSelected.Text = ">";
            this.btnMoveSelected.UseVisualStyleBackColor = true;
            this.btnMoveSelected.Click += new System.EventHandler(this.btnMoveSelected_Click);
            // 
            // btnMoveLeft
            // 
            this.btnMoveLeft.Location = new System.Drawing.Point(167, 79);
            this.btnMoveLeft.Name = "btnMoveLeft";
            this.btnMoveLeft.Size = new System.Drawing.Size(75, 23);
            this.btnMoveLeft.TabIndex = 8;
            this.btnMoveLeft.Text = "<";
            this.btnMoveLeft.UseVisualStyleBackColor = true;
            this.btnMoveLeft.Click += new System.EventHandler(this.btnMoveLeft_Click);
            // 
            // lstHeaders
            // 
            this.lstHeaders.FormattingEnabled = true;
            this.lstHeaders.Location = new System.Drawing.Point(31, 39);
            this.lstHeaders.Name = "lstHeaders";
            this.lstHeaders.Size = new System.Drawing.Size(120, 134);
            this.lstHeaders.TabIndex = 9;
            // 
            // numNumberOfRows
            // 
            this.numNumberOfRows.Location = new System.Drawing.Point(156, 12);
            this.numNumberOfRows.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numNumberOfRows.Name = "numNumberOfRows";
            this.numNumberOfRows.Size = new System.Drawing.Size(120, 20);
            this.numNumberOfRows.TabIndex = 10;
            this.numNumberOfRows.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numNumberOfRows.ValueChanged += new System.EventHandler(this.numNumberOfRows_ValueChanged);
            this.numNumberOfRows.KeyUp += new System.Windows.Forms.KeyEventHandler(this.numNumberOfRows_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "CSV Input Headers";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(254, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "CSV Output Headers";
            // 
            // btnMoveAll
            // 
            this.btnMoveAll.Location = new System.Drawing.Point(167, 108);
            this.btnMoveAll.Name = "btnMoveAll";
            this.btnMoveAll.Size = new System.Drawing.Size(75, 23);
            this.btnMoveAll.TabIndex = 13;
            this.btnMoveAll.Text = ">>";
            this.btnMoveAll.UseVisualStyleBackColor = true;
            this.btnMoveAll.Click += new System.EventHandler(this.btnMoveAll_Click);
            // 
            // btnMoveAllLeft
            // 
            this.btnMoveAllLeft.Location = new System.Drawing.Point(167, 137);
            this.btnMoveAllLeft.Name = "btnMoveAllLeft";
            this.btnMoveAllLeft.Size = new System.Drawing.Size(75, 23);
            this.btnMoveAllLeft.TabIndex = 14;
            this.btnMoveAllLeft.Text = "<<";
            this.btnMoveAllLeft.UseVisualStyleBackColor = true;
            this.btnMoveAllLeft.Click += new System.EventHandler(this.btnMoveAllLeft_Click);
            // 
            // groupHeaders
            // 
            this.groupHeaders.Controls.Add(this.label3);
            this.groupHeaders.Controls.Add(this.btnMoveAllLeft);
            this.groupHeaders.Controls.Add(this.label2);
            this.groupHeaders.Controls.Add(this.btnMoveAll);
            this.groupHeaders.Controls.Add(this.lstHeaders);
            this.groupHeaders.Controls.Add(this.lstOutputHeaders);
            this.groupHeaders.Controls.Add(this.btnMoveSelected);
            this.groupHeaders.Controls.Add(this.btnMoveLeft);
            this.groupHeaders.Enabled = false;
            this.groupHeaders.Location = new System.Drawing.Point(7, 104);
            this.groupHeaders.Name = "groupHeaders";
            this.groupHeaders.Size = new System.Drawing.Size(406, 185);
            this.groupHeaders.TabIndex = 15;
            this.groupHeaders.TabStop = false;
            this.groupHeaders.Text = "Headers";
            // 
            // chkManageHeaders
            // 
            this.chkManageHeaders.AutoSize = true;
            this.chkManageHeaders.Enabled = false;
            this.chkManageHeaders.Location = new System.Drawing.Point(7, 81);
            this.chkManageHeaders.Name = "chkManageHeaders";
            this.chkManageHeaders.Size = new System.Drawing.Size(154, 17);
            this.chkManageHeaders.TabIndex = 16;
            this.chkManageHeaders.Text = "Check to Manage Headers";
            this.chkManageHeaders.UseVisualStyleBackColor = true;
            this.chkManageHeaders.CheckedChanged += new System.EventHandler(this.chkManageHeaders_CheckedChanged);
            // 
            // groupCalc
            // 
            this.groupCalc.Controls.Add(this.lblCSVNo);
            this.groupCalc.Location = new System.Drawing.Point(419, 104);
            this.groupCalc.Name = "groupCalc";
            this.groupCalc.Size = new System.Drawing.Size(210, 185);
            this.groupCalc.TabIndex = 18;
            this.groupCalc.TabStop = false;
            this.groupCalc.Text = "File Summary";
            // 
            // lblCSVNo
            // 
            this.lblCSVNo.AutoSize = true;
            this.lblCSVNo.Location = new System.Drawing.Point(7, 29);
            this.lblCSVNo.Name = "lblCSVNo";
            this.lblCSVNo.Size = new System.Drawing.Size(0, 13);
            this.lblCSVNo.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "File Selected:";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(481, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 20;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 352);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupCalc);
            this.Controls.Add(this.chkManageHeaders);
            this.Controls.Add(this.numNumberOfRows);
            this.Controls.Add(this.lblFileSelected);
            this.Controls.Add(this.btnSplitFile);
            this.Controls.Add(this.btnSelectFile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupHeaders);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CSV Splitter";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numNumberOfRows)).EndInit();
            this.groupHeaders.ResumeLayout(false);
            this.groupHeaders.PerformLayout();
            this.groupCalc.ResumeLayout(false);
            this.groupCalc.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openCSVFileDialog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSelectFile;
        private System.Windows.Forms.Button btnSplitFile;
        private System.Windows.Forms.Label lblFileSelected;
        private System.Windows.Forms.ListBox lstOutputHeaders;
        private System.Windows.Forms.Button btnMoveSelected;
        private System.Windows.Forms.Button btnMoveLeft;
        private System.Windows.Forms.ListBox lstHeaders;
        private System.Windows.Forms.NumericUpDown numNumberOfRows;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnMoveAll;
        private System.Windows.Forms.Button btnMoveAllLeft;
        private System.Windows.Forms.GroupBox groupHeaders;
        private System.Windows.Forms.CheckBox chkManageHeaders;
        private System.Windows.Forms.GroupBox groupCalc;
        private System.Windows.Forms.Label lblCSVNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnExit;
    }
}

