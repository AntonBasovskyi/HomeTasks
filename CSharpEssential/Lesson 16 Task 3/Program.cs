using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 Создайте класс, который будет содержать информацию о дате (день, месяц, год). С помощью
механизма перегрузки операторов, определите операцию разности двух дат (результат в виде
количества дней между датами), а также операцию увеличения даты на определенное количество дней. 
 */

namespace Lesson_16_Task_3
{
    class Date
    {
        public DateTime date;
        public Date(DateTime date)
        {
            this.date = date;
        }
        public static Date operator -(DateTime date, Date date1)
        {
            return date - date1;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите день: ");
            int day = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите месяц: ");

            int month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите год: ");
            int year = Convert.ToInt32(Console.ReadLine());

            var currentDate = new Date(DateTime.Today);
            var date = new DateTime(year, month, day);
            var neededDate = new Date(date);
            var dateResult = currentDate.date - date;
            //int yearsResult = currentDate.date.Year > date.Year
            //    ? currentDate.date.Year - date.Year
            //    : date.Year - currentDate.date.Year;

            //int monthsResult = currentDate.date.Month > date.Month
            //    ? currentDate.date.Month - date.Month
            //    : date.Month - currentDate.date.Month;

            //int daysResult = currentDate.date.Day > date.Day
            //    ? currentDate.date.Day - date.Day
            //    : date.Day - currentDate.date.Day;
            Console.WriteLine(dateResult);
            Console.ReadKey();
        }
    }
}
