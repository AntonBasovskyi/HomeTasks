using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 Расширьте пример 5 (русско-английский словарь) еще и украинским словарем. Реализуйте возможность
поиска не только по ключевым русским словам и словам на остальных языках.
 */
namespace Lesson_5_Indexers
{
    class Program
    {
        static void Main(string[] args)
        {
            Book dictionary = new Book();
            Console.WriteLine("Введите слово: ");
            string str = Console.ReadLine();

            Console.WriteLine(dictionary[str]);

            // Delay.
            Console.ReadKey();
        }
    }
}
