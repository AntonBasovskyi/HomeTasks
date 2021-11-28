using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_3_Task_1.Classes
{
    class ExcelentPupil : Pupil
    {
        public override void Student(string a)
        {
            Console.WriteLine($"Ученик: {a}");
        }
        public override void Study()
        {
            Console.WriteLine("Учеба: зубрит все подряд.");
        }
        public override void Read(string b)
        {
            Console.WriteLine($"Читает: {b}") ;
        }
        public override void Write(string c)
        {
            Console.WriteLine($"Пишет: {c}");
        }
        public override void Relax()
        {
            Console.WriteLine("Отдыхает: Нет времени отдыхать.");
        }
    }
}
