using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Создайте четыре лямбда оператора для выполнения арифметических действий: (Add – сложение, Sub –
вычитание, Mul – умножение, Div – деление). Каждый лямбда оператор должен принимать два
аргумента и возвращать результат вычисления. Лямбда оператор деления должен делать проверку
деления на ноль.
Написать программу, которая будет выполнять арифметические действия, указанные пользователем. 
 */

namespace Lesson_9_Task_1
{

    class Program
    {
        public delegate decimal Functional(decimal a, decimal b);
        static void Main(string[] args)
        {

            Console.WriteLine("Введите первое число: ");
            decimal sum1 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Введите второе число: ");
            decimal sum2 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Выберите оператор: ");
            string @operator = Console.ReadLine();

            Functional 
                Add = (a, b) => a + b, 
                Sub = (a, b) => a - b, 
                Mul = (a, b) => a * b, 

                Div = (a, b) => b != 0 
                    ? a / b 
                    : -1;

            // можно просто if (sum2 == 0) cw("На ноль нельзя делить, мудак"); return;
            decimal result;

            switch (@operator)
            {
                case "+":
                    result = Add(sum1, sum2);
                    break;

                case "-":
                    result = Sub(sum1, sum2);
                    break;

                case "*":
                    result = Mul(sum1, sum2);
                    break;

                case "/":
                    result = Div(sum1, sum2);
                    break;

                default:
                    Console.WriteLine("Вы ввели неверный оператор.");
                    Console.ReadKey();
                    return;
            }
            
            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}