using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Создайте класс с методом помеченным модификатором доступа public. Докажите, что к данному
методу можно обратиться не только из текущей сборки, но и из производного класса внешней сборки. 
 */

namespace Lesson_18_Task_2
{
    public class MyClass
    {
        public void Merge()
        {
            Console.WriteLine("2 + 2 = 5");
        }

    }

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
