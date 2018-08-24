using System;
using FileReading;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FileReadingUnitTest
{
    [TestClass]
    public class ReadEncryptTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Context context;

            context = new Context(new ReadEncryptFile());
            var res = context.ContextInterface(@" C:\Users\Public\FlieToReadFolder\Crypted_Files\FileEncryptToRead.txt");

            Assert.AreEqual("Dushimimana Victor", res);
        }
    }
}
