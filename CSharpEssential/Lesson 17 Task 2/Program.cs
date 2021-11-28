using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 Используя динамические и анонимные типы данных, создайте Англо-Русский словарь на 10 слов и
выведите на экран его содержание. 
 */
namespace Lesson_17_Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            dynamic[] dictionary = new[]
            {   
                new {russian = "стол", english = "table" },
                new {russian = "яблоко", english = "apple" },
                new {russian = "банан", english = "banana" },
                new {russian = "стул", english = "chair", },
                new {russian = "мясо", english = "meat"},
                new {russian = "молоко", english = "milk"},
                new {russian = "часы", english = "watch"},
                new {russian = "звук", english = "sound"},
                new {russian = "еврей", english = "jew"},
                new {russian = "украинец", english = "superhuman"}
            };

            for (int i = 0; i < dictionary.Length; i++)
            {
                Console.WriteLine($"{dictionary[i].russian} == {dictionary[i].english}");
            }
            Console.ReadKey();
        }
    }
}
