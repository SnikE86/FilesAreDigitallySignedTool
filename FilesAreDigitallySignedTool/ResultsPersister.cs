using System;
using System.Collections.Generic;
using System.IO;

namespace FilesAreDigitallySignedTool
{
    class ResultsPersister
    {
        public void WriteToCsvFile(List<FileDetails> fileDetails)
        {
            var outputFileName = GetOutputName();

            Directory.CreateDirectory(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Tools", "FilesAreDigitallySigned"));

            using (var file =
            new StreamWriter(outputFileName))
            {
                file.WriteLine("Filename, FileExists, IsSigned, SignatureDate, SignatureVersion");

                foreach (var fileDetail in fileDetails)
                {
                    file.WriteLine(fileDetail.Filename
                           + "," + fileDetail.FileExists.ToString()
                           + "," + fileDetail.IsSigned.ToString()
                           + "," + fileDetail.SignatureDate.ToString()
                           + "," + fileDetail.SignatureVersion);
                }
            }
        }

        private static string GetOutputName()
        {
            var outputName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Tools", "FilesAreDigitallySigned", "results.csv");

            if (File.Exists(outputName))
            {
                var index = 1;

                index = GetFilenameIndex(outputName, index);

                outputName = Path.Combine(Path.GetDirectoryName(outputName), Path.GetFileNameWithoutExtension(outputName)) + index.ToString() + Path.GetExtension(outputName);
            }

            return outputName;
        }

        private static int GetFilenameIndex(string outputName, int index)
        {
            if (File.Exists(Path.Combine(Path.GetDirectoryName(outputName), Path.GetFileNameWithoutExtension(outputName)) + index.ToString() + Path.GetExtension(outputName)))
            {
                return GetFilenameIndex(outputName, index + 1);
            }
            else
            {
                return index;
            }
        }
    }
}
