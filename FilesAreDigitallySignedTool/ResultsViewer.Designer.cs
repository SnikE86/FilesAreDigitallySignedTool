namespace FilesAreDigitallySignedTool
{
    partial class ResultsViewer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResultsViewer));
            this.panelBottom = new System.Windows.Forms.Panel();
            this.buttonExport = new System.Windows.Forms.Button();
            this.panelTop = new System.Windows.Forms.Panel();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.fileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FileExists = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FileVersion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CopyrightDetails = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fileIsSigned = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SignatureVersion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SignatureDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelBottom.SuspendLayout();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.buttonExport);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 336);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(797, 36);
            this.panelBottom.TabIndex = 1;
            // 
            // buttonExport
            // 
            this.buttonExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExport.Location = new System.Drawing.Point(710, 6);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(75, 23);
            this.buttonExport.TabIndex = 0;
            this.buttonExport.Text = "Export";
            this.buttonExport.UseVisualStyleBackColor = true;
            this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.dataGridView);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(797, 336);
            this.panelTop.TabIndex = 2;
            // 
            // dataGridView
            // 
            this.dataGridView.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToOrderColumns = true;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fileName,
            this.FileExists,
            this.ProductName,
            this.FileVersion,
            this.CopyrightDetails,
            this.fileIsSigned,
            this.SignatureVersion,
            this.SignatureDate});
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(0, 0);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.Size = new System.Drawing.Size(797, 336);
            this.dataGridView.TabIndex = 1;
            // 
            // fileName
            // 
            this.fileName.HeaderText = "FileName";
            this.fileName.Name = "fileName";
            this.fileName.ReadOnly = true;
            this.fileName.Width = 76;
            // 
            // FileExists
            // 
            this.FileExists.HeaderText = "File Exists";
            this.FileExists.Name = "FileExists";
            this.FileExists.ReadOnly = true;
            this.FileExists.Width = 78;
            // 
            // ProductName
            // 
            this.ProductName.HeaderText = "Product Name";
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            // 
            // FileVersion
            // 
            this.FileVersion.HeaderText = "File Version";
            this.FileVersion.Name = "FileVersion";
            this.FileVersion.ReadOnly = true;
            this.FileVersion.Width = 86;
            // 
            // CopyrightDetails
            // 
            this.CopyrightDetails.HeaderText = "Copyright Details";
            this.CopyrightDetails.Name = "CopyrightDetails";
            this.CopyrightDetails.ReadOnly = true;
            this.CopyrightDetails.Width = 102;
            // 
            // fileIsSigned
            // 
            this.fileIsSigned.HeaderText = "File Is Digitally Signed";
            this.fileIsSigned.Name = "fileIsSigned";
            this.fileIsSigned.ReadOnly = true;
            this.fileIsSigned.Width = 123;
            // 
            // SignatureVersion
            // 
            this.SignatureVersion.HeaderText = "Signature Version";
            this.SignatureVersion.Name = "SignatureVersion";
            this.SignatureVersion.ReadOnly = true;
            this.SignatureVersion.Width = 105;
            // 
            // SignatureDate
            // 
            this.SignatureDate.HeaderText = "Signatue Date";
            this.SignatureDate.Name = "SignatureDate";
            this.SignatureDate.ReadOnly = true;
            this.SignatureDate.Width = 92;
            // 
            // ResultsViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 372);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelBottom);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ResultsViewer";
            this.Text = "FilesAreDigitallySigned";
            this.panelBottom.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Button buttonExport;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn fileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileExists;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileVersion;
        private System.Windows.Forms.DataGridViewTextBoxColumn CopyrightDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn fileIsSigned;
        private System.Windows.Forms.DataGridViewTextBoxColumn SignatureVersion;
        private System.Windows.Forms.DataGridViewTextBoxColumn SignatureDate;
    }
}