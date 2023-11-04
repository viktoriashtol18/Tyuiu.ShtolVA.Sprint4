﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ShtolVA.Sprint4.Task1.V16.Lib;

namespace Tyuiu.ShtolVA.Sprint4.Task1.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[] array = { 4, 3, 7, 3, 7, 4, 3, 3, 4, 4, 8, 3, 4 };
            int res = ds.Calculate(array);
            int wait = 11907;

            Assert.AreEqual(wait, res);
            

        }
    }
}
