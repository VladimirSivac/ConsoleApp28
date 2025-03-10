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
        // task3
        static void Main(string[] args)
        {
            int[] array = { 1, -5, 6, -19, 25, -1, 12, 21 };

            Console.WriteLine("Вывод массива до перестановки: ");
            ArrayPrinting(array);
            Console.WriteLine();

            int maxIndex = FindMaxElementIndex(array);
            SwapMaxFirstElements(array, maxIndex);

            Console.WriteLine("Вывод массива после перестановки максимального и 1-го элементов: ");
            ArrayPrinting(array);

            Console.ReadKey();
        }

        static int FindMaxElementIndex(int[] array)
        {
            int maxIndex = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > array[maxIndex])
                {
                    maxIndex = i;
                }
            }
            return maxIndex;
        }

        static void ArrayPrinting(int[] array)
        {
            foreach (int item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        static void SwapMaxFirstElements(int[] array, int maxIndex)
        {
            int temp = array[0];
            array[0] = array[maxIndex];
            array[maxIndex] = temp;
        }
    }
}