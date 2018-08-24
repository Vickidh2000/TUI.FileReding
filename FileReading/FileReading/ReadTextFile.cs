using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileReading
{
    public class ReadTextFile:ReadFile, IReadTextFile
    {
        public override object ReadingdFiles(string fileLocation)
        {
            var res = File.ReadAllText(fileLocation);

            return res;
        }

    }
}
