using System.Collections.Generic;
using System.Windows.Forms;

namespace FilesAreDigitallySignedTool
{
    public partial class ResultsViewer : Form
    {
        public ResultsViewer()
        {
            InitializeComponent();
        }

        public void SetupResultsForDisplay(List<FileDetails> fileDetails)
        {
            foreach (var fileDetail in fileDetails)
            {
                dataGridView.Rows.Add(fileDetail.Filename, 
                                      fileDetail.FileExists,  
                                      fileDetail.IsSigned.ToString(),
                                      fileDetail.SignatureVersion,
                                      fileDetail.SignatureDate);
            }
        }
    }
}
