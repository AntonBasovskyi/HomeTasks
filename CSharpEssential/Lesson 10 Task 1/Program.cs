using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Создайте класс MyList<T>. Реализуйте в простейшем приближении возможность использования его
экземпляра аналогично экземпляру класса List<T>. Минимально требуемый интерфейс
взаимодействия с экземпляром, должен включать метод добавления элемента, индексатор для
получения значения элемента по указанному индексу и свойство только для чтения для получения
общего количества элементов. 
 */

namespace Lesson_10_Task_1
{
    public class MyList<T>
    {
        T[] array = new T[0];

        public void Add(T element)
        {
            T[] newArray = new T[array.Length + 1];

            for (int i = 0; i < array.Length; i++)
                newArray[i] = array[i];

            newArray[newArray.Length - 1] = element;
            array = newArray;
        }

        public T this[int index] => array[index];

        public int Length => array.Length;
    }

    class Program
    {
        // TODO: rewrite code
        static void Main(string[] args)
        {
            MyList<string> myList = new MyList<string>();
            string element, exit = null, exit2 = null;

            while (exit != "нет")
            {
                Console.WriteLine("Добавьте элемент в список:");
                element = Console.ReadLine();
                myList.Add(element);

                Console.WriteLine("Хотите добавить еще?");
                exit = Console.ReadLine().ToLower();
            }

            while (exit2 != "да")
            {
                Console.WriteLine("Какой элемент вывести на экран?");
                int number = Convert.ToInt32(Console.ReadLine());

                if (number > myList.Length || number <= 0)
                    Console.WriteLine("Какая-то хуйня у тебя получается.");
                else
                    Console.WriteLine($"{number} элемент массива: {myList[number - 1]}");
           
                Console.WriteLine("Это все? ");
                exit2 = Console.ReadLine();
            }

            Console.WriteLine(myList[0]);
            Console.ReadKey();
        }
    }
}
