using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 Создайте класс House c двумя полями и свойствами.
Создайте два метода Clone() и DeepClone(), которые выполняют поверхностное и глубокое
копирование соответственно. Реализуйте простой способ проверки. 
 */
namespace Lesson_16_Task_2
{
    class Room
    {
        public string Area { get; set; }

        public Room(string area) =>
            Area = area;
    }

    class House
    {
        public string Walls { get; set; }
        public string Furniture { get; set; }
        public Room[] Rooms { get; set; }

        public object Clone()
        {
            return new House 
            { 
                Walls = this.Walls, 
                Furniture = this.Furniture,
                Rooms = this.Rooms
            };
        }

        public object DeepClone()
        {
            Room[] anotherHouseRooms = new Room[Rooms.Length];

            for (int i = 0; i < Rooms.Length; i++)
                anotherHouseRooms[i] = new Room(Rooms[i].Area);

            return new House 
            { 
                Walls = this.Walls, 
                Furniture = this.Furniture,
                Rooms = anotherHouseRooms
            };
        }
    }
}
