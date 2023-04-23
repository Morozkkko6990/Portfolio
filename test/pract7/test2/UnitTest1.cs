using Microsoft.VisualStudio.TestTools.UnitTesting;
using pract7;
using System;
using System.Linq;

namespace test2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Class1 class1 = new Class1();
            string a;
            string b = "456778";
            if (b.Length != b.Distinct().Count())
                a = "Yes";
            else
                a = "No";
            string exp = "Yes";
            string result = class1.Seven(a);
            Assert.AreEqual(exp, result);
        }
    }
}
