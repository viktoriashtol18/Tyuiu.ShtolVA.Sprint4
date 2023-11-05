using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.ShtolVA.Sprint4.Task3.V27.Lib;

namespace Tyuiu.ShtolVA.Sprint4.Task3.V27
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int[,] matrix = new int[5, 5] { { 4, 3, 5, 5, 3 },
                                          { 6, 7, 4, 4, 3 },
                                          { 3, 3, 7, 3, 6 },
                                          { 3, 4, 3, 7, 7 },
                                          { 3, 5, 6, 3, 6 } };
            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;


            Console.Title = "Спринт #4 | Выполнила: Штоль В.А. | ИИПб-23-3";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Обработка структурных типов                                       *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #27                                                             *");
            Console.WriteLine("* Выполнила: Штоль Виктория Алексеевна | ИИПб-23-3                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ: Дан двумерный целочисленный массив 5 на 5 элементов,           *");
            Console.WriteLine("* заполненный статическими значениями в диапазоне от 3 до 7.              *");
            Console.WriteLine("* Подсчитайте количество четных элементов во всем массиве.                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{matrix[i, j]} \t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            int res = ds.Calculate(matrix);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Количество четных элементов во всем массиве = " + res);
            Console.ReadKey();
        }
    }
}
