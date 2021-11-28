using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Создайте класс CarCollection<T>. Реализуйте в простейшем приближении возможность
использования его экземпляра для создания парка машин. Минимально требуемый интерфейс
взаимодействия с экземпляром, должен включать метод добавления машин с названием машины и
года ее выпуска, индексатор для получения значения элемента по указанному индексу и свойство
только для чтения для получения общего количества элементов.
Создайте метод удаления всех машин автопарка. 
 */

namespace Lesson_11_Task_1
{
    class CarCollection<T>
    {
        T[] cars = new T[0];
        T[] years = new T[0];

        public void Add(T key, T value)
        {
            Array.Resize(ref cars, cars.Length + 1);
            cars[cars.Length - 1] = key;

            Array.Resize(ref years, years.Length + 1);
            years[years.Length - 1] = value;
        }

        public (T, T) this[int key]
        {
            get
            {
                for (int i = 0; i < cars.Length; i++)
                {

                    if (cars.Length >= key)
                        return (cars[key], years[key]);

                }

                return (default, default);
            }
        }

        public void Delete()
        {
            cars = Array.Empty<T>();
            years = Array.Empty<T>();
        }

        public int Length => cars.Length;
    }

    class Program
    {
        static void Main(string[] args)
        {
            string exit = null, exit2 = null, key, value;
            CarCollection<string> carCollection = new CarCollection<string>();

            while (exit != "нет")
            {
                Console.WriteLine("Введите название машины: ");
                key = Console.ReadLine();

                Console.WriteLine("Год производства: ");
                value = Console.ReadLine();

                carCollection.Add(key, value);

                Console.WriteLine("Хотите добавить еще? ");
                exit = Console.ReadLine().ToLower();
            }

            Console.WriteLine($"Общее количество элементов: {carCollection.Length}");

            while (exit2 != "да")
            {
                Console.WriteLine("Какой элемент вывести на экран?");
                int number = Convert.ToInt32(Console.ReadLine());

                if (number > carCollection.Length || number <= 0)
                    Console.WriteLine("Какая-то хуйня у тебя получается.");
                else
                    Console.WriteLine($"Машинка №{number}: {carCollection[number - 1]}");

                Console.WriteLine("Это все? ");
                exit2 = Console.ReadLine().ToLower();
            }
            Console.WriteLine("Хотите удалить машинки?");
            string delete = Console.ReadLine().ToLower();

            if (delete == "да")
            {
                carCollection.Delete();
                Console.WriteLine("Машинок нет.");
            }
            else
                Console.WriteLine("До связи.");

            Console.ReadKey();
        }
    }
}
