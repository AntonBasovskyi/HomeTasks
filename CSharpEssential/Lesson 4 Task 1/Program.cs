using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lesson_4_Task_1.Classes;
/*
 Создайте класс AbstractHandler.
В теле класса создать методы void Open(), void Create(), void Chenge(), void Save().
Создать производные классы XMLHandler, TXTHandler, DOCHandler от базового класса
AbstractHandler.
Написать программу, которая будет выполнять определение документа и для каждого формата
должны быть методы открытия, создания, редактирования, сохранения определенного
формата документа. 
 */
namespace Lesson_4_Task_1
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("В каком формате будете работать?");
            string format = Console.ReadLine().ToUpper();

            AbstractHandler abstractHandler = null;
            switch (format)
            {
                case "XML":
                    abstractHandler = new XMLHandler();
                    break;

                case "TXT":
                    abstractHandler = new TXTHandler();
                    break;

                case "DOC":
                    abstractHandler = new DOCHandler();
                    break;

                default:
                {
                    Console.WriteLine("You have selected nothing!");
                    Console.ReadKey();

                    return;
                }
            }

            abstractHandler.Open();
            abstractHandler.Create();
            abstractHandler.Change();
            abstractHandler.Save();

            Console.ReadKey();
        }
    }
}
