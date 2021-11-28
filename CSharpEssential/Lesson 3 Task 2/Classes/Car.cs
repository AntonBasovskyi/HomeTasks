using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_3_Task_2.Classes
{
    class Car : Vehicle
    {

        public override void Counter()
        {
            vehicleSpeed = 220;
            vehiclePrice = 40_000;
            vehicleYear = 2011;
            Console.WriteLine("Автомобиль: ");
            Console.WriteLine($"Цена автомобиля: {vehiclePrice}, скорость: {vehicleSpeed}, год производства: {vehicleYear}.");
        }
    }

}
