using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.ShtolVA.Sprint4.Task2.V24.Lib
{
    public class DataService : ISprint4Task2V24
    {
        public int Calculate(int[] array)
        {
            int s = 0;

            for (int i = 0; i <= array.Length - 1; i++)
            {
                if (array[i] % 2 != 0)
                {
                    s += array[i];
                }
            }
            return s;
        }
    }
}