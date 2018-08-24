using System;
using System.Collections.Generic;
using FileReading;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FileReadingUnitTest
{
    [TestClass]
    public class ReadXmlFileTest
    {
        [TestMethod]
        public void TestMethod()
        {
            Context context;
            context = new Context(new ReadTextFile());
            var res = context.ContextInterface(@"C:\Users\Public\FlieToReadFolder\Text_Files");
            var actual = (List<string>)res;
            Assert.AreEqual("Belgian Waffles", actual[0]);

        }
    }
}
