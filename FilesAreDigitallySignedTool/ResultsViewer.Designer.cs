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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(ResultsViewer));
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.fileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FileExists = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fileIsSigned = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SignatureVersion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SignatureDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToOrderColumns = true;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fileName,
            this.FileExists,
            this.fileIsSigned,
            this.SignatureVersion,
            this.SignatureDate});
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(0, 0);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.Size = new System.Drawing.Size(797, 372);
            this.dataGridView.TabIndex = 0;
            // 
            // fileName
            // 
            this.fileName.HeaderText = "FileName";
            this.fileName.Name = "fileName";
            this.fileName.ReadOnly = true;
            // 
            // FileExists
            // 
            this.FileExists.HeaderText = "File Exists";
            this.FileExists.Name = "FileExists";
            this.FileExists.ReadOnly = true;
            // 
            // fileIsSigned
            // 
            this.fileIsSigned.HeaderText = "File Is Digitally Signed";
            this.fileIsSigned.Name = "fileIsSigned";
            this.fileIsSigned.ReadOnly = true;
            // 
            // SignatureVersion
            // 
            this.SignatureVersion.HeaderText = "Signature Version";
            this.SignatureVersion.Name = "SignatureVersion";
            this.SignatureVersion.ReadOnly = true;
            // 
            // SignatureDate
            // 
            this.SignatureDate.HeaderText = "Signatue Date";
            this.SignatureDate.Name = "SignatureDate";
            this.SignatureDate.ReadOnly = true;
            // 
            // ResultsViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 372);
            this.Controls.Add(this.dataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ResultsViewer";
            this.Text = "ResultsViewer";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn fileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileExists;
        private System.Windows.Forms.DataGridViewTextBoxColumn fileIsSigned;
        private System.Windows.Forms.DataGridViewTextBoxColumn SignatureVersion;
        private System.Windows.Forms.DataGridViewTextBoxColumn SignatureDate;
    }
}