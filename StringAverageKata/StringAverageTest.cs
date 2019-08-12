using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StringAverageKata
{
    [TestClass]
    public class StringAverageTest
    {
        private readonly StringAverage _stringAverage = new StringAverage();

        [TestMethod]
        public void All_Zero_return_Zero()
        {
            //act
            var actual = _stringAverage.GetAverage("zero zero zero zero");

            //assert
            Assert.AreEqual(0, actual);
        }

        [TestMethod]
        public void Five_One_return_One()
        {
            var actual = _stringAverage.GetAverage("one one one one one");

            Assert.AreEqual(1, actual);
        }

        [TestMethod]
        public void One_Two_Three_Four_Five_return_Three()
        {
            var actual = _stringAverage.GetAverage("one two three four five");

            Assert.AreEqual(3, actual);
        }
    }
}