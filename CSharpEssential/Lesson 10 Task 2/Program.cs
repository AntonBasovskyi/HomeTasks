using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Создайте класс MyDictionary<TKey,TValue>. Реализуйте в простейшем приближении возможность
использования его экземпляра аналогично экземпляру класса Dictionary (Урок 6 пример 5).
Минимально требуемый интерфейс взаимодействия с экземпляром, должен включать метод
добавления пар элементов, индексатор для получения значения элемента по указанному индексу и
свойство только для чтения для получения общего количества пар элементов.
 */

namespace Lesson_10_Task_2
{
    class MyDictionary<TKey, TValue>
    {
        TKey[] keys = new TKey[0];
        TValue[] values = new TValue[0];

        // TODO: add only if no such a key is present
        public void Add(TKey key, TValue value)
        {
            Array.Resize(ref keys, keys.Length + 1);
            keys[keys.Length - 1] = key;

            Array.Resize(ref values, values.Length + 1);
            values[values.Length - 1] = value;
        }

        public (TKey, TValue) this[int key]
        {
            get
            {
                for (int i = 0; i < keys.Length; i++)
                {
                    if (keys.Length >= key)
                        return (keys[key], values[key]);
                }

                return (default, default);
            }
        }

        public int Length => keys.Length;
    }

    class Program
    {
        // TODO: fulfill example
        static void Main(string[] args)
        {
            string exit = null, exit2 = null, key, value;

            var myDictionary = new MyDictionary<string, string>();
            while (exit != "нет")
            {
                Console.WriteLine("Добавьте слово: ");
                key = Console.ReadLine();

                Console.WriteLine("Добавьте перевод на буржуский: ");
                value = Console.ReadLine();

                myDictionary.Add(key, value);

                Console.WriteLine("Хотите добавить еще? ");
                exit = Console.ReadLine().ToLower();
            }

            Console.WriteLine($"Общее количество элементов: {myDictionary.Length}");

            while (exit2 != "да")
            {
                Console.WriteLine("Какой элемент вывести на экран?");
                int number = Convert.ToInt32(Console.ReadLine());

                if (number > myDictionary.Length || number <= 0)
                    Console.WriteLine("Какая-то хуйня у тебя получается.");
                else
                    Console.WriteLine($"{number} элемент массива: {myDictionary[number - 1]}");

                Console.WriteLine("Это все? ");
                exit2 = Console.ReadLine().ToLower();
            }

        }
    }
}


