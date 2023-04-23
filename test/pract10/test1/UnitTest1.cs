using Microsoft.VisualStudio.TestTools.UnitTesting;
using pract10;
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
            int b = 28;
            string c;
            for (int i = 2; i <= b; i++)
            {
                int r = 0;
                for (int j = 1; j <= i - 1; j++)
                {
                    if (i % j == 0)
                        r += j;
                }
                    if (r == i)
                        c = "Yes";
                    else
                        c = "No";
                    string exp = "Yes";
                    string result = class1.practicheskaya10(c);
                    Assert.AreEqual(exp, result);                
            }

          
        }
    
    }
}
