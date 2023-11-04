using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ShtolVA.Sprint4.Task0.V23.Lib;

namespace Tyuiu.ShtolVA.Sprint4.Task0.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultEvenArrEl()
        {
            DataService ds = new DataService();

            int[] nums = { 9, 3, 7, 1, 5, 5, 3, 2, 1, 7 };
            int res = ds.GetMultOddArrEl(nums);
            int wait = 99225;
            Assert.AreEqual(wait, res);
            
        }
    }
}
