using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 Создать класс Article, содержащий следующие закрытые поля:
• название товара;
• название магазина, в котором продается товар;
• стоимость товара в гривнах.
Создать класс Store, содержащий закрытый массив элементов типа Article.
Обеспечить следующие возможности:
• вывод информации о товаре по номеру с помощью индекса;
• вывод на экран информации о товаре, название которого введено с клавиатуры, если таких товаров
нет, выдать соответствующее сообщение;
Написать программу, вывода на экран информацию о товаре.

 */

namespace Lesson_5_Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Store store = new Store(new Article[]
            {
                new Article(productName: "Порошенко смокче", 
                            nameOfStore: "Ляшко і партнери", 
                            productPriceUah: 100),

                new Article(productName: "Чому Порошенко смокче за 100 гривень?", 
                            nameOfStore: "Кличко наш мер (блядь)", 
                            productPriceUah: 500),

                new Article(productName: "Кличко смокче у Порошенко, а Порошенко дав 100 гривень",
                            nameOfStore: "Під АТБ",
                            productPriceUah: 1000)
            });

            Console.WriteLine("Input article name to search");
            string productName = Console.ReadLine();

            for (int i = 0; i < store.Length; i++)
            {
                if (store[i].ProductName == productName)
                {
                    Console.WriteLine(store[i].NameOfStore);
                    Console.WriteLine(store[i].ProductPriceUah);

                    break;
                }
            }

            Console.ReadKey();
        }
    }
}
