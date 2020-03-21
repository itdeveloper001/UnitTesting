using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TDDUnitTesting
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int expected = 5;
            int num1 = 20;
            int num2 = 4;

            int actual = UnitTestingDemo.Calculation.Divide(num1, num2);

            //unit testing
            Assert.AreEqual(expected, actual);

            
        }
    }
}
