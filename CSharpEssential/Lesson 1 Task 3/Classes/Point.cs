using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_1_Task_3.Classes
{
    class Point
    {
        // Точка имеет координаты
        int x;
        int y;

        // Строковый аргумент - имя точки.
        // Нахуй она тут нужна, я не ёбу, но факт остается фактом.
        // Если уже написали - "строковый аргумент" - так, блядь, напишите что именно он значит :)
        string name;

        public int X => x;
        public int Y => y;
        public string Name => name;

        public Point(int x, int y, string name)
        {
            this.x = x;
            this.y = y;
            this.name = name;
        }
    }
}
