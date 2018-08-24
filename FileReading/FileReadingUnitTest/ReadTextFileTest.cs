﻿using System;
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
            Context context;

            context = new Context(new ReadTextFile());
            var res = context.ContextInterface(@" C:\Users\Public\FlieToReadFolder\Text_Files\FileToRead.txt");

            Assert.AreEqual("Dushimimana Victor", res);
        }
    }
}
