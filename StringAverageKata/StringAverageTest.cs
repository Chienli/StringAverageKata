using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StringAverageKata
{
    [TestClass]
    public class StringAverageTest
    {
        [TestMethod]
        public void All_Zero_return_Zero()
        {
            //arrange
            var stringAverage = new StringAverage();

            //act
            var actual = stringAverage.GetAverage("zero zero zero zero");

            //assert
            Assert.AreEqual(0, actual);
        }
    }
}