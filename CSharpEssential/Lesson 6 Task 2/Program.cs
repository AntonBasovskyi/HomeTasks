using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
    Расширьте пример урока 005_Delegation, создав в классе Book, вложенный класс Notes, который
    позволит сохранять заметки читателя. 
 */
namespace Lesson_6_Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите слово для перевода: ");
            string str = Console.ReadLine();

            str.FindNext();

            // Delay.
            Console.ReadKey();
        }
    }
}
