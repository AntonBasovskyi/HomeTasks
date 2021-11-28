using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Создайте анонимный метод, который принимает в качестве аргумента массив делегатов и возвращает
среднее арифметическое возвращаемых значений методов, сообщенных с делегатами в массиве.
Методы, сообщенные с делегатами из массива, возвращают случайное значение типа int. 
 */

namespace Lesson_9_Task_2
{
    static class MyClass
    {
        public static Random rnd = new Random();

        public static int Method1()
        {
            return rnd.Next(1, 100);
        }

        public static int Method2()
        {
            return rnd.Next(100, 200);
        }

        public static int Method3()
        {
            return rnd.Next(200, 400);
        }

        public delegate int MyDelegate();
    }

    delegate int DelegateArray(MyClass.MyDelegate[] delegates);

    class Program
    {

        static void Main(string[] args)
        {
            MyClass.MyDelegate[] delegates = new MyClass.MyDelegate[]
            {
                MyClass.Method1,
                MyClass.Method2,
                MyClass.Method3
            };

            var @delegate = new DelegateArray((delegateArray) =>
            {
                int sum = 0;

                for (int i = 0; i < delegateArray.Length; i++)
                {
                    int delegateResult = delegates[i]();
                    Console.Write($"Элемент {i + 1}: {delegateResult}\n");
                    sum += delegateResult;
                }

                return sum / delegates.Length;
            });

            int average = @delegate(delegates);
            Console.WriteLine($"Среднее арифметическое: {average}");

            Console.ReadKey();
        }
    }
}
