using System;
using FileReading;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FileReadingUnitTest
{
    [TestClass]
    public class ReadTextFileTest
    {
        [TestMethod]
        public void TestMethod()
        {
            IReadTextFile read = new ReadTextFile();

            Assert.AreEqual("Dushimimana Victor", read.ReadingdFiles(@" C:\Users\Public\FlieToReadFolder\Text_Files\FileToRead.txt"));
        }
    }
}
