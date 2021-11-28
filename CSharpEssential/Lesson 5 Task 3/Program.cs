using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_5_Task_3
{

    class Program
    {
        static void Main(string[] args)
        {
            MyMatrix matrix = new MyMatrix();

            Console.WriteLine("Введите размер первого измерения: ");
            int first = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите размер второго измерения: ");
            int second = Convert.ToInt32(Console.ReadLine());

            matrix.Matrix(first, second);

            Console.ReadKey();
        }
    }
}
