using Microsoft.VisualStudio.TestTools.UnitTesting;
using pract9._2;
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
            int b = 2;
            int c = 4;
            string s;
            if (a==b||c==b||c==a)
                s = "Yes";
            else
                s = "No";
            string exp = "Yes";
            string result = class1.practicheskaya9(s);
            Assert.AreEqual(exp, result);
        }
    }
}
