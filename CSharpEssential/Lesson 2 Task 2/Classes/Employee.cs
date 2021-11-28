using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2_Task_2.Classes
{
    class Employee
    {
        public string name, surname;

        public string post;
        public int experience, payment;

        public Employee(string name, string surname)
        {
            this.name = name;
            this.surname = surname;
        }

        public void Information()
        {
            (int salary, int tax) = CalculateSalaryAndTax();

            Console.WriteLine($"{name} {surname} занимает такую должность: {post}, и имеет такой оклад: {payment} гривен,\n" +
                $"с учетом опыта работы {experience} лет он получает зарплату {salary} гривен, налоговый сбор: {tax} гривен.");
        }

        (int salary, int tax) CalculateSalaryAndTax()
        {
            int expirienceMultiplier;

            if (experience < 30)
                expirienceMultiplier = experience * payment / 100;
            else
                expirienceMultiplier = 30 * payment / 100;

            int salary = payment + expirienceMultiplier;
            int tax = salary / 100 * 20;

            return (salary, tax);
        }
    }
}
