using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
    Используя Visual Studio, создайте проект по шаблону Console Application.
    Требуется: Создать класс с именем Rectangle. 
    В теле класса создать два поля, описывающие длины сторон double side1, side2.
    Создать пользовательский конструктор Rectangle(double side1, double side2), в теле которого
    поля side1 и side2 инициализируются значениями аргументов.
    Создать два метода, вычисляющие площадь прямоугольника - double AreaCalculator() и периметр
    прямоугольника - double PerimeterCalculator().
    Создать два свойства double Area и double Perimeter с одним методом доступа get.
    Написать программу, которая принимает от пользователя длины двух сторон прямоугольника и выводит
    на экран периметр и площадь.
 */

namespace Lesson_1_Task_1
{
    class Rectangle
    {
        private double side1;
        private double side2;

        public Rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }

        //public Rectangle(double side1, double side2) =>
        //    (this.side1, this.side2) = (side1, side2);

        private double AreaCalculator()
        {
            return side1 * side2;
        }

        //private double AreaCalculator() =>
        //    side1 * side2;

        private double PerimeterCalculator()
        {
            return 2 * (side1 + side2);
        }

        //private double PerimeterCalculator() =>
        //    2 * (side1 + side2);

        public double Area
        {
            get
            {
                return AreaCalculator();
            }
        }

        //public double Area => AreaCalculator();

        public double Perimeter
        {
            get
            {
                return PerimeterCalculator();
            }
        }

        //public double Perimeter => PerimeterCalculator();
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину первой стороны: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите длину второй стороны: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Rectangle rectangle = new Rectangle(a, b);
            Console.WriteLine($"Площадь: {rectangle.Area}, периметр: {rectangle.Perimeter}");

            Console.ReadKey();
        }
    }
}
