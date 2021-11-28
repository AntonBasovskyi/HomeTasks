using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
    Создать статический класс FindAndReplaceManager с методом void FindNext(string str) для
    поиска по книге из примера урока 005_Delegation. При вызове этого метода, производится
    последовательный поиск строки в книге. 
 */

namespace Lesson_6_Task_1
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите слово для перевода: ");
            string str = Console.ReadLine();

            FindAndReplaceManager.FindNext(str);

            // Delay.
            Console.ReadKey();
        }
    }
}
