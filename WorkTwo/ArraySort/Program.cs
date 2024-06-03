using System;
using System.Reflection;

namespace ArraySort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  Массив из примера.
            int[,] a = { { 7, 3, 2 }, { 4, 9, 6 }, { 1, 8, 5 } };
            //  Тестовые массивы.
            int[,] b = { { 0, 1, 9 }, { 8, 5, 5 } };
            int[,] c = { { 0, 2, 1, 3 }, { 8, 4, 4, 9 }, { 4, 3, 8, 7 } };
            //  Вывод изначального состояния массива.
            printArray(a);
            printArray(b);
            printArray(c);
        
            //  Вызов метода сортировки.
            a = sortArray(a);
            //  Вывод отсоритрованного массива.
            printArray(a);

            b = sortArray(b);
            c = sortArray(c);
            printArray(b);
            printArray(c);
        }

        //  Метод сортировки.
        static int[,] sortArray(int[,] arr)
        {
            //  Временный одномерный массив равный размеру двумерного массива.
            int[] temp = new int[ arr.GetLength(0) * arr.GetLength(1) ];
            //  Запись всех значений двумерного массива во временный массив.
            for (int i = 0, index = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++, index++)
                {
                    temp[index] = arr[i, j];
                }
            }

            //  Сортировка временного массива.
            Array.Sort(temp);

            //  Запись зачений в исходный(передннай в метод) массив.
            for (int i = 0, index = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++, index++)
                {
                    arr[i, j] = temp[index];
                }
            }
            return arr;
        }

        //  Метод распечатки двумерного массива.
        static void printArray(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write($"{arr[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
