using System.Collections.Generic;
using AuthenticodeExaminer;
using System.Linq;

namespace FilesAreDigitallySignedTool
{
    class DigitalSignatureChecker
    {
        public void Execute(List<FileDetails> fileDetails)
        {
            foreach (var fileDetail in fileDetails)
            {
                var extractor = new FileInspector(fileDetail.Filename);                
                fileDetail.IsSigned = extractor.Validate() == SignatureCheckResult.Valid;

                if (fileDetail.IsSigned)
                {
                    fileDetail.SignatureVersion = extractor.GetSignatures().FirstOrDefault()?.SigningCertificate.Version.ToString();
                    fileDetail.SignatureDate = extractor.GetSignatures().FirstOrDefault()?.TimestampSignatures.FirstOrDefault()?.TimestampDateTime?.UtcDateTime.ToString();
                }
            }
        }
    }
}
