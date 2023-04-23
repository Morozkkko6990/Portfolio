using Microsoft.VisualStudio.TestTools.UnitTesting;
using pract9;
using System;

namespace test2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Class1 class1 = new Class1();
            double a = 2.243;
            double b=43.23;
            double c=2.243;
            string s;
            if (a ==b||b==c||a==c)
                s = "Yes";
            else
                s = "No";
            string exp = "Yes";
            string result = class1.interval(s);
            Assert.AreEqual(exp, result);
        }
    }
}
