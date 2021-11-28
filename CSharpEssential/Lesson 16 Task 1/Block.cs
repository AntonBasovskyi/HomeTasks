using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 Создайте класс Block с 4-мя полями сторон, переопределите в нем методы:
Equals – способный сравнивать блоки между собой,
ToString – возвращающий информацию о полях блока. 
 */
namespace Lesson_16_Task_1
{
    class Block
    {
        public int sideA = 15;
        public int sideB = 20;
        public int sideC = 25;
        public int sideD = 30;
        public override bool Equals(object obj)
        {
            if (obj == null || this.GetType() != obj.GetType())
                return false;

            Block block = (Block)obj;

            return (sideA == block.sideA)
                && (sideB == block.sideB) 
                && (sideC == block.sideC) 
                && (sideD == block.sideD);
        }
        public override int GetHashCode()
        {
            return sideA ^ sideB ^ sideC ^ sideD;
        }

        public override string ToString()
        {
            return string.Format($"Side A: {sideA}, Side B: {sideB}, Side C: {sideC}, Side D: {sideD}");
        }
    }
}
