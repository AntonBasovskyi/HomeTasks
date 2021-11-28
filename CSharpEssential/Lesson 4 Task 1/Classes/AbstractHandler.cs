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
    abstract class AbstractHandler
    {
        abstract public void Open();

        abstract public void Create();

        abstract public void Change();

        abstract public void Save();
    }
}