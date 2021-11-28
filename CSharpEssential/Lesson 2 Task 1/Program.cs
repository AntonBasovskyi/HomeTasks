using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Lesson_2_Task_1.Classes;

/*
    Создать класс Converter.
    В теле класса создать пользовательский конструктор, который принимает три вещественных аргумента,
    и инициализирует поля соответствующие курсу 3-х основных валют, по отношению к гривне – public
    Converter(double usd, double eur, double rub).
    Написать программу, которая будет выполнять конвертацию из гривны в одну из указанных валют,
    также программа должна производить конвертацию из указанных валют в гривну. 
 */

namespace Lesson_2_Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Converter exchange = new Converter(usd: 26.9, eur: 32, rub: 0.37);

            Console.Write("Введите количество: "); 
            double amount = Convert.ToDouble(Console.ReadLine());

            Console.Write("Назовите валюту: ");
            string fromCurrency = Console.ReadLine().ToLower();

            Console.Write("В какую валюту конвертировать? ");
            string toCurrency = Console.ReadLine().ToLower();

            Console.WriteLine($"У вас {exchange.Convert(amount, fromCurrency, toCurrency)} {toCurrency}");
            Console.ReadKey();
        }
    }
}
