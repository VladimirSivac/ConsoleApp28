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
        //task 4
        static void Main(string[] args)
        {
            double[] array = new double[] { 63.5, 63.2, 63.57, 62.87, 64.31, 63.5, 63.24, 64.12, 62.59, 63.78, 63.42, 63.77 };
            
            AverageValue(array);
            MaxValue(array);
            MinValue(array);
        }
        
        static void AverageValue(double[] array)
        {
            double sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            double average = sum / array.Length;
            Console.WriteLine($"Среднее значение ЗП = {average:F2}");
        }
        
        static void MaxValue(double[] array)
        {
            double max = array[0];
            int index = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                    index = i;
                }
            }
            Console.WriteLine($"Максимальная ЗП в {index + 1} день, равна {max}");
        }
        
        static void MinValue(double[] array)
        {
            double min = array[0];
            int index = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                    index = i;
                }
            }
            Console.WriteLine($"Минимальная ЗП в {index + 1} день, равна {min}");
        }
    }
}