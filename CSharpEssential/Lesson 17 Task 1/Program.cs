using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Представьте, что вы пишите приложение для Автостанции и вам необходимо создать простую
коллекцию автомобилей со следующими данными: Марка автомобиля, модель, год выпуска, цвет. А
также вторую коллекцию с моделью автомобиля, именем покупателя и его номером телефона.
Используя простейший LINQ запрос, выведите на экран информацию о покупателе одного из
автомобилей и полную характеристику приобретенной ними модели. 
 */
namespace Lesson_17_Task_1
{
    class AutomobileCollection
    {
        public string Mark { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
    }

    class CustomerCollection
    {
        public string Model { get; set; }
        public string NameOfCustomer { get; set; }
        public int PhoneNumber { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var automobiles = new List<AutomobileCollection>
            {
                new AutomobileCollection
                {
                    Mark = "BMW",
                    Model = "E5",
                    Year = 2011,
                    Color = "Белая"
                },

                new AutomobileCollection
                {
                    Mark = "Audi",
                    Model = "TT",
                    Year = 2015,
                    Color = "Черная"
                }
            };

            var info = new List<CustomerCollection>
            {
                new CustomerCollection
                {
                    NameOfCustomer = "Сергей Дружко",
                    PhoneNumber = 123456789,
                    Model = "E5"
                },

                new CustomerCollection
                {
                    NameOfCustomer = "Андрей Малахов",
                    PhoneNumber = 987654321,
                    Model = "TT"
                }
            };

            var query = from automobile in automobiles
                        join customer in info
                        on automobile.Model equals customer.Model
                        orderby customer.NameOfCustomer
                        select new
                        {
                            Mark = automobile.Mark,
                            Model = automobile.Model,
                            Year = automobile.Year,
                            Color = automobile.Color,
                            NameOfCustomer = customer.NameOfCustomer,
                            PhoneNumber = customer.PhoneNumber
                        };

            foreach (var item in query)
            {
                Console.WriteLine($"Имя клиента: {item.NameOfCustomer}\nНомер клиента: {item.PhoneNumber}\n" +
                $"Марка автомобиля: {item.Mark}\nМодель: {item.Model}\nГод выпуска: {item.Year}\nЦвет: {item.Color}");
            }

            Console.ReadKey();
        }
    }
}
