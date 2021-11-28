using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
/*
 Создайте коллекцию MyDictionary<TKey,TValue>. Реализуйте в простейшем приближении
возможность использования ее экземпляра аналогично экземпляру класса Dictionary<TKey,TValue>.
Минимально требуемый интерфейс взаимодействия с экземпляром, должен включать метод
добавления элемента, индексатор для получения значения элемента по указанному индексу и свойство
только для чтения для получения общего количества элементов. Реализуйте возможность перебора
элементов коллекции в цикле foreach.
 */
namespace Lesson_14_Task_2
{
    public class MyDictionary <TKey, TValue> : IEnumerable, IEnumerator
    {

            TKey[] keys = new TKey[0];
            TValue[] values = new TValue[0];

            public void Add(TKey key, TValue value)
            {
                Array.Resize(ref keys, keys.Length + 1);
                keys[keys.Length - 1] = key;

                Array.Resize(ref values, values.Length + 1);
                values[values.Length - 1] = value;
            }

            public (TKey, TValue) this[int key]
            {
                get
                {
                    for (int i = 0; i < keys.Length; i++)
                    {

                        if (keys.Length >= key)
                            return (keys[key], values[key]);

                    }

                    return (default, default);
                }
            }

            public int Length => keys.Length;
            int position = -1;
        public bool MoveNext()
        {
            if (position < keys.Length - 1)
            {
                position++;
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Reset()
        {
            position = -1;
        }
        public object Current
        {
            get { return keys[position]; }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this as IEnumerator;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string exit = null, key, value;

            var myDictionary = new MyDictionary<string, string>();

            while (exit != "нет")
            {
                Console.WriteLine("Добавьте слово: ");
                key = Console.ReadLine();

                Console.WriteLine("Добавьте перевод на буржуский: ");
                value = Console.ReadLine();

                myDictionary.Add(key, value);

                Console.WriteLine("Хотите добавить еще? ");
                exit = Console.ReadLine().ToLower();
            }

            Console.WriteLine($"Общее количество элементов: {myDictionary.Length}");

            foreach(var element in myDictionary)
            {
                int i = 0;
                Console.WriteLine($"{ myDictionary[i].Item1} == {myDictionary[i].Item2}");
                i++;
            }

            Console.ReadKey();
        }
    }
}
