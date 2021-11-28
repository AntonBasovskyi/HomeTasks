using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MyDictionary = Lesson_14_Task_2.MyDictionary<string, string>;

/*
 Используя пример выполненного домашнего задания 3 из 15 урока, реализуйте возможность
подключения вашего пространства имен и работы с MyDictionary<TKey,TValue> аналогично
экземпляру класса Dictionary<TKey,TValue>. 
 */
namespace Lesson_18_Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var myDictionary = new MyDictionary();

            Console.WriteLine("Введите слово: ");
            string key = Console.ReadLine();

            Console.WriteLine("Введите перевод: ");
            string value = Console.ReadLine();

            myDictionary.Add(key, value);

            Console.WriteLine($"{myDictionary[0].Item1} => {myDictionary[0].Item2}");

            Console.ReadKey();
        }
    }
}
