using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_6_Task_2
{
    static class FindAndReplaceManager
    {
        static Book Book { get; }

        static FindAndReplaceManager() =>
            Book = new Book();

        public static void FindNext(this string str)
        {
            Console.WriteLine(Book[str]);
            Console.WriteLine(new string('-', 29));
        }
    }
}
