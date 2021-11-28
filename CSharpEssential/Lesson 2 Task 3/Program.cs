using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    Создать класс Invoice.

    В теле класса создать три поля int account, string customer, string provider, 
    которые должны быть проинициализированы один раз (при создании экземпляра данного класса) без возможности их дальнейшего изменения.

    В теле класса создать два закрытых поля string article, int quantity.
    Создать метод расчета стоимости заказа с НДС и без НДС.

    Написать программу, которая выводит на экран сумму оплаты заказанного товара с НДС или без НДС
*/

namespace Lesson_2_Task_3
{
    class Invoice
    {
        readonly int account;
        readonly string customer;
        readonly string provider;

        string article;
        int quantity;

        public Invoice(int account, string customer, string provider, string article, int quantity)
        {
            this.account = account;
            this.customer = customer;
            this.provider = provider;
            this.article = article;
            this.quantity = quantity;
        }

        public void OutputInfo()
        {
            (int totalWithoutVAT, int totalWithVAT) = Calculate_TotalPrice_WithAndWithoutVAT();

            if (customer.Contains("Попрошенко"))
            {
                Console.WriteLine($"{customer} хочет купить {article} от поставщика {provider}\n" +
                    $"Без учета НДС: {totalWithoutVAT} грн., с учетом НДС: доплати народу України + \\ {totalWithVAT} грн.");

                Console.WriteLine("Смачного вам, Петро Олексійовичу!");
            }
            else
            {
                Console.WriteLine($"{customer} хочет купить {article} от поставщика {provider}\n" +
                    $"Без учета НДС: {totalWithoutVAT} грн., с учетом НДС: {totalWithVAT * -1} грн.");
            }
        }

        (int totalWithoutVAT, int totalWithVAT) Calculate_TotalPrice_WithAndWithoutVAT()
        {
            int totalWithoutVAT = account * quantity;

            int VAT = totalWithoutVAT / 100 * 20;
            int totalWithVAT = totalWithoutVAT - VAT;

            return (totalWithoutVAT, totalWithVAT);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Invoice invoice = new Invoice(
                account: 37219921, 
                customer: "Петро Олексійович Попрошенко", 
                provider: "Ні хуя собі. Все людям!",
                article: "Хуї в маслі",
                quantity: 100);

            invoice.OutputInfo();

            Console.ReadKey();
        }
    }
}
