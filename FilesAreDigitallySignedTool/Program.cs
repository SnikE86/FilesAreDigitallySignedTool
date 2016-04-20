using System.Collections.Generic;
using System.Windows.Forms;

namespace FilesAreDigitallySignedTool
{
    class Program
    {
        static void Main(string[] args)
        {
            var fileDetails= new List<FileDetails>();
            var filenamePopulator = new FilenamePopulator();
            var digitalSignatureChecker = new DigitalSignatureChecker();
            var resultsViewer = new ResultsViewer();

            filenamePopulator.Execute(fileDetails);
            digitalSignatureChecker.Execute(fileDetails);
            resultsViewer.SetupResultsForDisplay(fileDetails);

            if (args.Length > 0)
            {
                var persister = new ResultsPersister();
                persister.WriteToCsvFile(fileDetails);
            }
            else
            {
                Application.Run(resultsViewer);
            }
        }
    }
}
