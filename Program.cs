using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    /// <summary>
    /// Компьютерный практикум № 28 (05.03.2025), task 1
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[14];
            ArrayFilling(array);
            ArrayPrinting(array);
            Console.ReadKey();
        }
            
        static void ArrayFilling(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"arr[{i}] = ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
            
        static void ArrayPrinting(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                    Console.WriteLine($"arr[{i}] = {array[i]}");
            }
        }
    }
}