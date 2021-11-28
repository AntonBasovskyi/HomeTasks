using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Создайте статический класс с методом void Print(string stroka, int color), который выводит на
экран строку заданным цветом. Используя перечисление, создайте набор цветов, доступных
пользователю. Ввод строки и выбор цвета предоставьте пользователю. 
 */

namespace Lesson_8_Task_1
{
    enum Colors
    {
        Yellow,
        Blue,
        Red
    }

    static class Printer
    {
        public static void Print(string str, int colorIndex)
        {
            var color = (Colors)colorIndex;

            switch (color)
            {
                case Colors.Red:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;

                case Colors.Blue:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;

                case Colors.Yellow:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
            }

            Console.WriteLine(str);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите цвет: ");
            string str = Console.ReadLine();

            Printer.Print(str, (int)Enum.Parse(typeof(Colors), str));

            Console.ReadKey();
        }
    }
}