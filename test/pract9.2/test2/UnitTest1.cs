using Microsoft.VisualStudio.TestTools.UnitTesting;
using pract9._2;
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
            int a = 223133;
            int q, w, e, r, t, y;
            q = a % 10;
            w = a /10%10;
            e = a / 100 % 10;
            r = a / 1000 % 10;
            t = a / 10000 % 10;
            y = a / 100000 % 10;
            string s;
            if (q+w+e==r+t+y)
                s = "Yes";
            else
                s = "No";
            string exp = "Yes";
            string result = class1.practicheskaya9(s);
            Assert.AreEqual(exp, result);
        }
    }
}
