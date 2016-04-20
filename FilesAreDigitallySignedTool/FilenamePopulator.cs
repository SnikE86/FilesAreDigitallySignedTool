using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.IO;

namespace FilesAreDigitallySignedTool
{
    class FilenamePopulator
    {
        public void Execute(List<FileDetails> fileDetails)
        {
            var section = (Hashtable)ConfigurationManager.GetSection("fileNames");

            foreach(string fileName in section.Values){
                var fileDetail = new FileDetails();

                fileDetail.Filename = fileName;

                fileDetail.FileExists = File.Exists(fileName);

                fileDetails.Add(fileDetail);
            }
        }
    }
}
