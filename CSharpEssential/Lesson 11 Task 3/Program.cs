using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 Создайте класс ArrayList. Реализуйте в простейшем приближении возможность использования его
экземпляра аналогично экземпляру класса ArrayList из пространства имен System.Collections.
 */

namespace Lesson_11_Task_3
{
    class ArrayList
    {
        object[] array = new object[0];

        public void Add(object element)
        {
            object[] newArray = new object[array.Length + 1];

            for (int i = 0; i < array.Length; i++)
                newArray[i] = array[i];

            newArray[newArray.Length - 1] = element;
            array = newArray;
        }

        public object this[int index] => array[index];

        public int Count => array.Length;
    }

    class Program
    {
        static void Main(string[] args)
        {
            var arrayList = new ArrayList();
            string element, exit = null, exit2 = null;


            while (exit2 != "да")
            {
                while (exit != "нет")
                {
                    Console.WriteLine("Добавьте элемент в список: ");
                    element = Console.ReadLine();
                    arrayList.Add(element);

                    Console.WriteLine("Хотите добавить еще? ");
                    exit = Console.ReadLine().ToLower();
                }

                Console.WriteLine("Какой элемент вывести на экран?");
                int number = Convert.ToInt32(Console.ReadLine());

                if (number > arrayList.Count || number <= 0)
                    Console.WriteLine("Какая-то хуйня у тебя получается.");
                else
                    Console.WriteLine($"{number} элемент массива: {arrayList[number - 1]}");

                Console.WriteLine("Это все? ");
                exit2 = Console.ReadLine();
            }

            Console.ReadKey();
        }
    }
}
