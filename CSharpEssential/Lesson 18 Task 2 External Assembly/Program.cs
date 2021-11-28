using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Lesson_18_Task_2;

namespace Lesson_18_Task_2_External_Assembly
{
    class Program
    {
        static void Main(string[] args)
        {
            var myClass = new MyClass();
            myClass.Merge();

            Console.ReadKey();
        }
    }
}
