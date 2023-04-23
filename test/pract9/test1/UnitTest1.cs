using Microsoft.VisualStudio.TestTools.UnitTesting;
using pract9;
using System;

namespace test1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Class1 class1 = new Class1();
            int a = 2;
            string b;
            if (a >= -5 && a <= 3)
                b = "Yes";
            else
                b = "No";
            string exp = "Yes";
            string result = class1.interval(b);
            Assert.AreEqual(exp, result);
        }
    }
}
