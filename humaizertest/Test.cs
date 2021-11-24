using System;
using System.Collections.Generic;
using System.Text;
using humaizertest;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework.Internal;

namespace humaizertest
{
    class Test
    {
        [TestMethod]
        private void TestMethod1()
        {
            string input = "100.50";
            string[] actual = input.Split('.');
            string[] expected = { "100", "50" };
            CollectionAssert.AreEqual(actual, expected);
        }
    }
}