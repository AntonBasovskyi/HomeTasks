using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lesson_3_Task_2.Classes;
/*
 Создать класс Vehicle.
В теле класса создайте поля: координаты и параметры средств передвижения (цена, скорость, год
выпуска).
Создайте 3 производных класса Plane, Саг и Ship.
Для класса Plane должна быть определена высота и количество пассажиров.
Для класса Ship — количество пассажиров и порт приписки.
Написать программу, которая выводит на экран информацию о каждом средстве передвижения. 
 */
namespace Lesson_3_Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle plane = new Plane();
            Vehicle ship = new Ship();
            Vehicle car = new Car();

            plane.Counter();
            ship.Counter();
            car.Counter();

            Console.ReadKey();
        }
    }
}
