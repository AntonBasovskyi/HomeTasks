using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

/*
 Требуется: Описать структуру с именем Train, содержащую следующие поля: название пункта
назначения, номер поезда, время отправления.
Написать программу, выполняющую следующие действия:
- ввод с клавиатуры данных в массив, состоящий из восьми элементов типа Train (записи должны быть
упорядочены по номерам поездов);
- вывод на экран информации о поезде, номер которого введен с клавиатуры (если таких поездов нет,
вывести соответствующее сообщение). 
 */

namespace Lesson_7_Task_1
{
    struct Train
    {
        public string destination;
        public int trainNumber;
        public string departureTime;

        public Train(string destination, int trainNumber, string departureTime)
        {
            this.destination = destination;
            this.departureTime = departureTime;
            this.trainNumber = trainNumber;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int numberOfTrains = 8;
            Train[] trains = new Train[numberOfTrains];

            for (int i = 0; i < trains.Length; i++)
            {
                Console.WriteLine($"Введите место прибытия поезда {i + 1}: ");
                string destination = Console.ReadLine();

                int trainNumber = i + 1;

                Console.WriteLine($"Введите время прибытия поезда {trainNumber}: ");
                string departureTime = Console.ReadLine();

                Train train = new Train(destination, trainNumber, departureTime);
                trains[i] = train;
            }

            Console.WriteLine("Введите номер поезда: ");
            int number = Convert.ToInt32(Console.ReadLine());

            bool found = false;
            for (int i = 0; i < trains.Length; i++)
            {
                if (number == trains[i].trainNumber)
                    found = true;

                if (found)
                {
                    Console.WriteLine($"Поезд под номером {trains[i].trainNumber} " +
                        $"прибывает: {trains[i].destination} " +
                        $"в указанное время: {trains[i].departureTime}");

                    break;
                }
            }

            if (!found)
                Console.WriteLine("Вы ввели неверный номер поезда. ");

            Console.ReadKey();
        }
    }
}