using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using pract7._2;

namespace test1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Class1 class1 = new Class1();
            int a = 123456;
            string b;
            while (a>0)
            {
                if (a % 10 > a / 10 % 10)
                {
                    a /= 10;
                }
                else
                    b = "No";
                        break;
                if(a<=0)
                    b = "Yes";
            }
            string exp = "Yes";
            string result = class1.zadach(a);
            Assert.AreEqual(exp, result);
        }
    }
}
