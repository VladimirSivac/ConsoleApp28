using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    /// <summary>
    /// Компьютерный практикум № 28 (05.03.2025)
    /// </summary>
    internal class Program
    {
        // task2
        static void Main(string[] args)
        {
            int[] array = new int[9];
            RandomFilling(array);
            ArrayPrinting(array);
            int func1 = Func1(array);
            int func2 = Func2(array);
            FunctionResultPrinting(func1, func2);

            Console.ReadKey();
        }

        static void RandomFilling(int[] arr)
        {
            Random rand = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(-20, 20);
            }
        }

        static void ArrayPrinting(int[] array)
        {
            int i = 0;
            foreach (var element in array)
            {
                Console.Write($"array[{i}] = {element}\n");
                i++;
            }
        }

        static void FunctionResultPrinting(int func1, int func2)
        {
            Console.WriteLine($"Количество четных элементов: {func1}");
            Console.WriteLine($"Количество нечетных элементов: {func2}");
            if (func1 > func2)
                Console.WriteLine("Четных элементов больше");
            else if (func2 > func1)
                Console.WriteLine("Нечетных элементов больше");
            else
                Console.WriteLine("Четных и нечетных элементов одинаково");
        }

        static int Func1(int[] array)
        {
            int n = 0; //    -
            foreach (var element in array)
            {
                if (element % 2 == 0)
                    n++;
            }
            return n;
        }

        static int Func2(int[] array)
        {
            int n = 0; //    -
            foreach (var element in array)
            {
                if (!(element % 2 == 0))
                    n++;
            }
            return n;
        }
    }
}