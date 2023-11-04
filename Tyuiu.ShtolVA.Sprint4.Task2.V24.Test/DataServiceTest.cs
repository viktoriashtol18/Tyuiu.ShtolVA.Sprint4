using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ShtolVA.Sprint4.Task2.V24.Lib;

namespace Tyuiu.ShtolVA.Sprint4.Task2.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[] array = { 7, 6, 6, 7, 9, 5, 4, 5, 7, 6, 8, 9 };
            int res = ds.Calculate(array);
            int wait = 49;
            Assert.AreEqual(wait, res);
            
        }
    }
}
