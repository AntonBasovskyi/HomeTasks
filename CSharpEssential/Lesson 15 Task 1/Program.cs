using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 Требуется: Описать структуру с именем Worker, содержащую следующие поля:
• фамилия и инициалы работника;
• название занимаемой должности;
• год поступления на работу.
Написать программу, выполняющую следующие действия:
• ввод с клавиатуры данных в массив, состоящий из пяти элементов типа Worker (записи должны
быть упорядочены по алфавиту);
• если значение года введено не в соответствующем формате выдает исключение.
• вывод на экран фамилии работника, стаж работы которого превышает введенное значение
 */
namespace Lesson_15_Task_1
{
    public struct Worker
    {
        public Worker(string surname, string initials, string post, int year)
        {
            Surname = surname;
            Initials = initials;
            Post = post;
            Year = year;
        }
        public string Surname { get; set; }
        public string Initials { get; set; }
        public string Post { get; set; }
        public int Year { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Worker[] workers = new Worker[5];
            for (int i = 0; i < workers.Length; i++)
            {

                Console.WriteLine("Введите имя и фамилию сотрудника: ");
                string nameAndSurname = Console.ReadLine();

                string[] surname = nameAndSurname.Split(new char[] { ' ' });

                string initials = $"{nameAndSurname.First()}. {surname[1].First()}.";

                Console.WriteLine("Должность: ");
                string post = Console.ReadLine();

                    Console.WriteLine("Год поступления на работу: ");
                    string year = Console.ReadLine();

                    try
                    {
                        int years = Convert.ToInt32(year);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Вы допустили ошибку.");
                        Console.WriteLine(e.Message);
                    }   

                workers[i] = new Worker(surname[1], initials, post, Convert.ToInt32(year));
            }
            Array.Sort(workers);
            Console.WriteLine("Введите требуемый стаж: ");
            int experience = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Сотрудники, у которых стаж работы больше {experience}:");
            for (int i = 0; i < workers.Length; i++)
            {
                int currentYear = DateTime.Now.Year;

                if (currentYear - workers[i].Year > experience)
                {
                    Console.WriteLine($"{workers[i].Surname}");
                }
            }

            Console.ReadLine();
        }
    }
}
