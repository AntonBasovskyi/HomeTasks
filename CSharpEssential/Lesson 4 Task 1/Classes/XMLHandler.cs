using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 Создайте класс AbstractHandler.
В теле класса создать методы void Open(), void Create(), void Chenge(), void Save().
Создать производные классы XMLHandler, TXTHandler, DOCHandler от базового класса
AbstractHandler.
Написать программу, которая будет выполнять определение документа и для каждого формата
должны быть методы открытия, создания, редактирования, сохранения определенного
формата документа. 
 */
namespace Lesson_4_Task_1.Classes
{
    class XMLHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("Вы открыли документ в формате XML.");
        }

        public override void Create()
        {
            Console.WriteLine("Вы создали документ в формате XML.");
        }

        public override void Change()
        {
            Console.WriteLine("Редактирование документа: ");
            string a = Console.ReadLine();
            Console.WriteLine($"Новый текст:\n{a}");
        }

        public override void Save()
        {
            Console.WriteLine("Документ сохранен в формате XML.");
        }
    }
}
