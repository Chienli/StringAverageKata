﻿using System;
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
    }
}