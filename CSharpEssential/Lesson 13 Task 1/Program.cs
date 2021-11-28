using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace Lesson_13_Task_1
/*
 * Создайте программу, которая будет выводить на экран цепочки падающих символов. Длина каждой
цепочки задается случайно. Первый символ цепочки – белый, второй символ – светло-зеленый,
остальные символы темно-зеленые. Во время падения цепочки, на каждом шаге, все символы меняют
свое значение. Дойдя до конца, цепочка исчезает и сверху формируется новая цепочка. Смотрите ниже
снимок экрана, представленный как образец. 
 */
{
    class Program
    {
        public static Random random = new Random();
        public static char GetLetter()
        {
            string chars = "$%#@!*abcdefghijklmnopqrstuvwxyz1234567890?;:ABCDEFGHIJKLMNOPQRSTUVWXYZ^&";
            int num = random.Next(chars.Length);
            return chars[num];
        }
        static void Main(string[] args)
        {


            int maxCount = new Random().Next(1,9);
            for (int i = 0; i < maxCount; i++)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write($"{new string(' ', 20)}{GetLetter()}" +
                              $"{new string(' ', 30)}" +
                              $"{GetLetter()}{new string(' ', 40)}{GetLetter()}");
                Console.WriteLine();
                Thread.Sleep(300);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"{new string(' ', 20)}{GetLetter()}" +
                              $"{new string(' ', 30)}" +
                              $"{GetLetter()}{new string(' ', 40)}{GetLetter()}");
                Console.WriteLine();
                Thread.Sleep(300);
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write($"{new string(' ', 20)}{GetLetter()}" +
                              $"{new string(' ', 30)}" +
                              $"{GetLetter()}{new string(' ', 40)}{GetLetter()}");
                Console.WriteLine();
                Thread.Sleep(300);

            }

        }
    }
}
