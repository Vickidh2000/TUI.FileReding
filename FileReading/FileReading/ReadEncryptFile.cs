using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileReading
{
    public class ReadEncryptFile : ReadFile
    {
        public override object ReadingdFiles(string fileLocation)
        {
            
            var res = File.ReadAllText(fileLocation);

            return ReverseDecoding(res);
        }

        public string ReverseDecoding(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

    }

  
}
