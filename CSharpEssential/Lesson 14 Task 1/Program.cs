using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 Создайте коллекцию MyList<T>. Реализуйте в простейшем приближении возможность использования
ее экземпляра аналогично экземпляру класса List<T>. Минимально требуемый интерфейс
взаимодействия с экземпляром, должен включать метод добавления элемента, индексатор для
получения значения элемента по указанному индексу и свойство только для чтения для получения
общего количества элементов. Реализуйте возможность перебора элементов коллекции в цикле
foreach.
 */
namespace Lesson_14_Task_1
{
    class MyList<T> : IEnumerable, IEnumerator
    {
        object[] array = new object[0];
        int position = -1;
        public bool MoveNext()
        {
            if(position <array.Length - 1)
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
            get { return array[position]; }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this as IEnumerator;
        }
        public void Add(T element)
        {
            object[] newArray = new object[array.Length + 1];

            for (int i = 0; i < array.Length; i++)
                newArray[i] = array[i];

            newArray[newArray.Length - 1] = element;
            array = newArray;
        }

        public object this[int index] => array[index];

        public int Count => array.Length;
    }
    class Program
    {
        static void Main(string[] args)
        {
            var myList = new MyList<int>();
            myList.Add(15);
            myList.Add(40);

            foreach(int item in myList)
            {
                int i = 0;
                Console.WriteLine(myList[i]);
                i++;
            }

            Console.WriteLine(myList.Count);

            Console.ReadKey();
        }
    }
}
