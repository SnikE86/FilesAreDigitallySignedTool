using System.Collections.Generic;
using System.Windows.Forms;

namespace FilesAreDigitallySignedTool
{
    class Program
    {
        static void Main(string[] args)
        {
            var fileDetails = new List<FileDetails>();
            var filenamePopulator = new FilenamePopulator();
            var digitalSignatureChecker = new DigitalSignatureChecker();
            var fileDetailPopulator = new FileDetailPopulator();
            var persister = new ResultsPersister();

            filenamePopulator.Execute(fileDetails);
            digitalSignatureChecker.Execute(fileDetails);
            fileDetailPopulator.Execute(fileDetails);

            if (args.Length > 0)
            {
                persister.WriteToCsvFile(fileDetails);
            }
            else
            {
                var resultsViewer = new ResultsViewer(persister);
                resultsViewer.SetupResultsForDisplay(fileDetails);
                Application.Run(resultsViewer);
            }
        }
    }
}
