using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ShtolVA.Sprint4.Task5.V26.Lib;

namespace Tyuiu.ShtolVA.Sprint4.Task5.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
            {
                DataService ds = new DataService();

                int[,] array = { {3, 4, -1, -2, 0},
                             { 4, 0, -4, 3, 4},
                             { 0, 3, -3, -3, 0},
                             { -4, 4, 1, -1, -1 },
                             { -3, 4, 3, 4, -1}};

                int[,] wait = {{1, 1, -1, -2, 1},
                        { 1, 1, -4, 1, 1},
                        { 1, 1, -3, -3, 1},
                        { -4, 1, 1, -1, -1 },
                        { -3, 1, 1, 1, -1}};

                int[,] res = ds.Calculate(array);

                CollectionAssert.AreEqual(wait, res);
            }
    }
}
