using Microsoft.VisualStudio.TestTools.UnitTesting;
using pract_10._2;
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
            int x = 26612;
            string b;
            int tmp = -1;
            while (x != 0)
            {
                if (tmp == x % 10)
                {
                    b = "Yes";
                    tmp = x % 10;
                    x /= 10;
                }
                else
                    b = "No";
                string exp = "Yes";
                string result = class1.zadanie(b);
                Assert.AreEqual(exp, result);
            }
                
        }
    }
}
