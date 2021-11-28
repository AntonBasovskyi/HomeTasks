using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Требуется: создать расширяющий метод для целочисленного массива, который сортирует элементы
массива по возрастанию. 
 */

namespace Lesson_6_Task_3
{
    static class Extension
    {
        static void Swap(ref int firstElement, ref int secondElement)
        {
            var temp = firstElement;

            firstElement = secondElement;
            secondElement = temp;
        }

        public static void Sort(this int[] value)
        {
            for (int i = 1; i < value.Length; i++)
            {
                for (int j = 0; j < value.Length - i; j++)
                {
                    if (value[j] > value[j + 1])
                        Swap(ref value[j], ref value[j + 1]);
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] array = new int[rnd.Next(3, 20)];

            for (int i = 0; i < array.Length; i++)
                array[i] = rnd.Next(1, 100);

            for (int i = 0; i < array.Length; i++)
                Console.Write($"{array[i]} ");

            Console.WriteLine();

            array.Sort();

            for (int i = 0; i < array.Length; i++)
                Console.Write($"{array[i]} ");

            Console.ReadKey();
        }
    }
}
