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
    class Plane : Vehicle
    {
        int planeHeight = 10_000, planePassengers = 189;

        public Plane() =>
            (vehicleYear, vehiclePrice, vehicleSpeed) = (1997, 78_300_000, 800);

        public override void Counter()
        {
            Console.WriteLine("Воздушное судно: ");
            Console.WriteLine($"Количество пассажиров: {planePassengers}, цена судна: {vehiclePrice}, " +
                $"скорость полёта: {vehicleSpeed} км/ч, год производства: {vehicleYear}, высота полета: {planeHeight} метров.");
        }
    }
}
