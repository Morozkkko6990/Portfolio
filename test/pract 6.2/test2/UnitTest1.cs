using Microsoft.VisualStudio.TestTools.UnitTesting;
using pract_6._2;
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
            string a;
            int b = 22;
            if (b/10==b-((b/10)*10))
                a = "Yes";
            else
                a = "No";
            string exp = "Yes";
            string result = class1.Seven(a);
            Assert.AreEqual(exp, result);
        }
    }
}
