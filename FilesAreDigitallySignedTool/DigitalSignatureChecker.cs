using System;
using System.Collections.Generic;
using System.Management.Automation;
using System.Management.Automation.Runspaces;
using Mono.Security.Authenticode;

namespace FilesAreDigitallySignedTool
{
    class DigitalSignatureChecker
    {
        public void Execute(List<FileDetails> fileDetails)
        {
            foreach (var fileDetail in fileDetails)
            {
                if (fileDetail.FileExists)
                {
                    Signature signature;

                    if(GetFileSignature(fileDetail.Filename, out signature))
                    {
                        fileDetail.IsSigned = (signature.Status == SignatureStatus.Valid);

                        var deformatter = new AuthenticodeDeformatter(fileDetail.Filename);

                        if (deformatter.SigningCertificate != null)
                        {
                            fileDetail.SignatureVersion = deformatter.SigningCertificate.Version.ToString();
                            fileDetail.SignatureDate = deformatter.Timestamp.ToString();
                        }
                    }
                }
            }
        }

        private static bool GetFileSignature(string fileName, out Signature signature)
        {
            try
            {
                var runspaceConfiguration = RunspaceConfiguration.Create();
                var runspace = RunspaceFactory.CreateRunspace(runspaceConfiguration);
                runspace.Open();

                var pipeline = runspace.CreatePipeline();
                pipeline.Commands.AddScript("Get-AuthenticodeSignature \"" + fileName + "\"");

                var results = pipeline.Invoke();
                runspace.Close();
                signature = results[0].BaseObject as Signature;

                return signature != null;
            }
            catch (Exception e)
            {
                throw new Exception("Error when trying to check if file is signed:" + fileName + " --> " + e.Message);
            }
        }
    }
}
