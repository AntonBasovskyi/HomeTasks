using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 Создайте класс House c двумя полями и свойствами.
Создайте два метода Clone() и DeepClone(), которые выполняют поверхностное и глубокое
копирование соответственно. Реализуйте простой способ проверки. 
 */
namespace Lesson_16_Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            House house = new House();

            House houseClone = house.Clone() as House;
            House houseDeepClone = house.DeepClone() as House;
            house.Furniture = "Кровать";
            houseClone.Furniture = "Диван";
            houseDeepClone.Furniture = "Биван";

            Console.WriteLine(house.Furniture);
            Console.WriteLine(houseClone.Furniture);
            Console.WriteLine(houseDeepClone.Furniture);
            Console.ReadKey();
        }
    }
}
