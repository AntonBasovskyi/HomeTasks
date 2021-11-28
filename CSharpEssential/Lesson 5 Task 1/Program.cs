using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 Создать массив размерностью N элементов, заполнить его произвольными целыми значениями.
Вывести наибольшее значение массива, наименьшее значение массива, общую сумму элементов,
среднее арифметическое всех элементов, вывести все нечетные значения.

 */
namespace Lesson_5_Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество элементов: ");
            int elementsCount = Convert.ToInt32(Console.ReadLine());

            if (elementsCount <= 0)
                return;

            int[] array = new int[elementsCount];
            Random random = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(1, 1000);
            }

            int sum = 0;

            foreach (int value in array)
            {
                sum += value;
            }

            double average = sum / array.Length;

            int max = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                    max = array[i];
            }

            int min = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < min)
                    min = array[i];
            }

            Console.WriteLine($"Максимальное значение: {max}");
            Console.WriteLine($"Минимальное значение: {min}");
            Console.WriteLine($"Сумма элементов массива: {sum}");
            Console.WriteLine($"Среднее арифметическое всех элементов массива: {average}");

            Console.Write("Все нечетные элементы массива: ");
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                    Console.Write($"{array[i]} ");
            }

            Console.ReadKey();
        }
    }
}
