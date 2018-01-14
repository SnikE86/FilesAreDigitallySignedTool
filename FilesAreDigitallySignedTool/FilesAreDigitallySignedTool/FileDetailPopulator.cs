using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilesAreDigitallySignedTool
{
    class FileDetailPopulator
    {
        public void Execute(List<FileDetails> fileDetails)
        {
            foreach (var fileDetail in fileDetails)
            {
                if (fileDetail.FileExists)
                {
                    var versionInfo = FileVersionInfo.GetVersionInfo(fileDetail.Filename);

                    if (versionInfo != null)
                    {
                        if (versionInfo.FileVersion != null)
                        {
                            fileDetail.FileVersion = versionInfo.FileVersion;
                        }

                        if (versionInfo.LegalCopyright != null)
                        {
                            fileDetail.CopyrightDetails = versionInfo.LegalCopyright;
                        }

                        if (versionInfo.ProductName != null)
                        {
                            fileDetail.ProductName = versionInfo.ProductName;
                        }
                    }
                }
            }
        }
    }
}
