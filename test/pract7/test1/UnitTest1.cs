﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using pract7;
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
            string a;
            int b = 146;
            if (b / 100 == b % 10)
                a = "Yes";
            else
                a = "No";
            string exp = "Yes";
            string result = class1.Seven(a);
            Assert.AreEqual(exp, result);
        }
    }
}