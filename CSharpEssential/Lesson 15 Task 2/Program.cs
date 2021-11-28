using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 Требуется: Описать структуру с именем Price, содержащую следующие поля:
• название товара;
• название магазина, в котором продается товар;
• стоимость товара в гривнах.
Написать программу, выполняющую следующие действия:
• ввод с клавиатуры данных в массив, состоящий из двух элементов типа Price (записи должны
быть упорядочены в алфавитном порядке по названиям магазинов);
• вывод на экран информации о товарах, продающихся в магазине, название которого введено с
клавиатуры (если такого магазина нет, вывести исключение).

 */
namespace Lesson_15_Task_2
{
    public struct Price
    {
        public string NameOfProduct { get; set; }
        public string NameOfStore { get; set; }
        public int PriceUah { get; set; }

        public Price(string nameOfProduct, string nameOfStore, int priceUah)
        {
            NameOfProduct = nameOfProduct;
            NameOfStore = nameOfStore;
            PriceUah = priceUah;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Price[] prices = new Price[2];
            for (int i = 0; i < prices.Length; i++)
            {
                Console.WriteLine("Введите наименование продукта: ");
                string nameOfProduct = Console.ReadLine();

                Console.WriteLine("Введите наименование магазина: ");
                string nameOfStore = Console.ReadLine();

                Console.WriteLine("Введите цену на продукт: ");
                int priceUah = Convert.ToInt32(Console.ReadLine());

                prices[i] = new Price(nameOfProduct, nameOfStore, priceUah);
            }

            bool isNameOfStore = false;
            Console.WriteLine("Введите интересующий вас магазин: ");
            string store = Console.ReadLine().ToLower();
            for (int i = 0; i < prices.Length; i++)
            {
                if (store == prices[i].NameOfStore)
                {
                    Console.WriteLine($"Наименование магазина: {prices[i].NameOfStore}, " +
                    $"наименование товара: {prices[i].NameOfProduct}, цена: {prices[i].PriceUah} ");
                    isNameOfStore = true;
                    break;
                }
            }
            if (!isNameOfStore)
            {
                throw new Exception("Не в тот магаз постучался");
            }
            Console.ReadKey();
        }
    }
}
