using Microsoft.VisualStudio.TestTools.UnitTesting;
using pract10;
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
            int n = 666;
            string d;
            int a, b, c;
            a = n / 100;
            b = (n / 10) % 10;
            c=n % 10;
            if (a == b && b == c && c == a)
                d = "Yes";
            else
                d = "No";
            string exp = "Yes";
            string result = class1.practicheskaya10(d);
            Assert.AreEqual(exp, result);
               
        }
    }
}
