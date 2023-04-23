using Microsoft.VisualStudio.TestTools.UnitTesting;
using pract_10._2;
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
            int n = 676;
            string d;
            int a, b, c;
            a = n / 100;
            b = (n / 10) % 10;
            c = n % 10;
            if (a ==0|| b == 0|| c == 0)
                d = "Yes";
            else
                d = "No";
            string exp = "Yes";
            string result = class1.zadanie(d);
            Assert.AreEqual(exp, result);
        }
    }
}
