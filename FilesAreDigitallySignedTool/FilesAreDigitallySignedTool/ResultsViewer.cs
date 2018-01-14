using System.Collections.Generic;
using System.Windows.Forms;

namespace FilesAreDigitallySignedTool
{
    public partial class ResultsViewer : Form
    {
        ResultsPersister _persister;
        List<FileDetails> _fileDetails;

        public ResultsViewer(ResultsPersister persister)
        {
            _persister = persister;            

            InitializeComponent();
        }

        public void SetupResultsForDisplay(List<FileDetails> fileDetails)
        {
            _fileDetails = fileDetails;

            foreach (var fileDetail in fileDetails)
            {
                dataGridView.Rows.Add(fileDetail.Filename,
                                      fileDetail.FileExists,
                                      fileDetail.ProductName,
                                      fileDetail.FileVersion,
                                      fileDetail.CopyrightDetails,
                                      fileDetail.IsSigned.ToString(),
                                      fileDetail.SignatureVersion,
                                      fileDetail.SignatureDate);
            }

            var lastColIndex = this.dataGridView.Columns.Count - 1;
            this.dataGridView.Columns[lastColIndex].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void buttonExport_Click(object sender, System.EventArgs e)
        {
            _persister.WriteToCsvFile(_fileDetails);
            MessageBox.Show("Export complete", "FilesAreDigitallySigned", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
