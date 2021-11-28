using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Lesson_2_Task_2.Classes;

/*
    Создать класс Employee.

    В теле класса создать пользовательский конструктор, который принимает два строковых аргумента, и инициализирует поля, соответствующие фамилии и имени сотрудника.
    Создать метод рассчитывающий оклад сотрудника (в зависимости от должности и стажа) и налоговый сбор.

    Написать программу, которая выводит на экран информацию о сотруднике (фамилия, имя, должность), оклад и налоговый сбор. 
*/

namespace Lesson_2_Task_2
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите имя сотрудника: ");
            string name = Console.ReadLine();

            Console.Write("Введите фамилию сотрудника: ");
            string surname = Console.ReadLine();

            Employee employee = new Employee(name, surname)
            {
                post = "Коровам дрочить і баті час від часу",
                payment = 6_000,
                experience = 70
            };

            employee.Information();

            Console.ReadKey();
        }
    }
}
