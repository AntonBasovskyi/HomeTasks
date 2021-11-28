using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 Создать класс Vehicle.
В теле класса создайте поля: координаты и параметры средств передвижения (цена, скорость, год
выпуска).
Создайте 3 производных класса Plane, Саг и Ship.
Для класса Plane должна быть определена высота и количество пассажиров.
Для класса Ship — количество пассажиров и порт приписки.
Написать программу, которая выводит на экран информацию о каждом средстве передвижения. 
 */
namespace Lesson_3_Task_2.Classes
{
    class Ship : Vehicle
    {
        int shipPassengers = 500;
        string shipPort = "Детройт";

        public Ship() =>
            (vehicleYear, vehiclePrice, vehicleSpeed) = (1985, 1_500_000, 230);

        public override void Counter()
        {
            Console.WriteLine("Судно: ");
            Console.WriteLine($"Количество пассажиров: {shipPassengers}, цена судна: {vehiclePrice}, " +
                $"скорость лодки: {vehicleSpeed}, год производства: {vehicleYear}, Порт приписки: {shipPort}.");
        }
    }
}
