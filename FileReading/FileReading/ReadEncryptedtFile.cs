using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileReading
{
    public class ReadEncryptedtFile : ReadFile, IReadEncryptedFile
    {
        public override object ReadingdFiles(string fileLocation)
        {
            // Implementation of Encrypted files to finish 

            byte[] fileBytes = File.ReadAllBytes(fileLocation);

            return fileBytes;
        }

    }
}
