using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 Создайте класс Block с 4-мя полями сторон, переопределите в нем методы:
Equals – способный сравнивать блоки между собой,
ToString – возвращающий информацию о полях блока. 
 */
namespace Lesson_16_Task_1
{

    class Program
    {
        static void Main(string[] args)
        {
            Block block = new Block();

            Console.WriteLine(block.ToString());

            Console.ReadKey();
        }
    }
}
