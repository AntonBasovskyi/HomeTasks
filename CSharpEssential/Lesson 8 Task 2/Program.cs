using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Создайте перечисление, в котором будут содержаться должности сотрудников как имена констант.
Присвойте каждой константе значение, задающее количество часов, которые должен отработать
сотрудник за месяц.
Создайте класс Accauntant с методом bool AskForBonus(Post worker, int hours), отражающее
давать или нет сотруднику премию. Если сотрудник отработал больше положеных часов в месяц, то ему
положена премия. 
 */

namespace Lesson_8_Task_2
{
    class Accountant
    {
        public enum Post
        {
            Cashier = 72,
            Accountant = 64,
            Baker = 68
        }

        public static bool AskForBonus(Post worker, int hours)
        {
            if (hours > (int)worker)
                return true;

            if (hours < 10)
                Console.WriteLine("Братан, у тебя проблемы.");

            return false;
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Введите должность сотрудника: ");
            string str = Console.ReadLine().ToLower();

            Accountant.Post worker;
            switch (str)
            {
                case "кассир":
                    worker = Accountant.Post.Cashier;
                    break;

                case "бухгалтер":
                    worker = Accountant.Post.Accountant;
                    break;

                case "пекарь":
                    worker = Accountant.Post.Baker;
                    break;

                default:
                    Console.WriteLine("Вы неверно ввели должность.");
                    Console.ReadKey();
                    return;
            }

            Console.WriteLine("Введите количество проработанных часов");
            int hours = Convert.ToInt32(Console.ReadLine());

            string bonus;
            if (Accountant.AskForBonus(worker, hours))
                bonus = "Положена";
            else
                bonus = "Не положена";

            Console.WriteLine($"Положена ли премия сотруднику? {bonus}.");
            Console.ReadKey();
        }
    }
}
