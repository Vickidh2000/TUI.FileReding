using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileReading
{
    public class Context
    {
        private ReadFile _readFile;

        // Constructor


        public Context(ReadFile readFile)
        {
            this._readFile = readFile;
        }

        public object ContextInterface(string filelocation)
        {
            return _readFile.ReadingdFiles(filelocation);
        }
    }
}
