using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Lesson_1_Task_3.Classes;

namespace Lesson_1_Task_3
{
    /*
        Используя Visual Studio, создайте проект по шаблону Console Application.

        Требуется:
            Создать классы Point и Figure.
            Класс Point должен содержать два целочисленных поля и одно строковое поле.
            Создать три свойства с одним методом доступа get.
            Создать пользовательский конструктор, в теле которого проинициализируйте поля значениями аргументов. 
            Класс Figure должен содержать конструкторы, которые принимают от 3-х до 5-ти аргументов типа Point.

        Создать два метода: double LengthSide(Point A, Point B), который рассчитывает длину стороны многоугольника:
            void PerimeterCalculator(), который рассчитывает периметр многоугольника.

        Написать программу, которая выводит на экран название и периметр многоугольника. 
    */

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите x: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите y: ");
            int y = Convert.ToInt32(Console.ReadLine());

            Figure figure = new Figure(
                new Point(x: 0, y: 0, name: "A"),
                new Point(x: 0, y: 10, name:  "B"),
                new Point(x: 5, y: 0, name: "C"));

            figure.PerimeterCalculator();
            Console.ReadKey();
        }
    }
}
 