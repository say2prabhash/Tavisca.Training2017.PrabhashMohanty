using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tavisca.Training2017.Handson.TrailingZeroTest
{
    [TestClass]
    public class FactorialTrailingZero
    {
        [TestMethod]
        public void TrailingZero_Test(int zeroes,int result)
        {
            Assert.AreEqual(zeroes, result);
        }
    }
}
