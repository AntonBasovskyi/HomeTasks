using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_1_Task_3.Classes
{
    class Figure
    {
        // Хранит в себе набор точек фигуры
        Point[] points;

        // Принимает различные количества точек.
        // Мы не вызываем предыдущие конструкторы так как механизм расширения массивов неоптимален
        #region Constructors

        public Figure(Point a, Point b, Point c) =>
            points = new Point[] { a, b, c };

        public Figure(Point a, Point b, Point c, Point d) =>
            points = new Point[] { a, b, c, d };

        public Figure(Point a, Point b, Point c, Point d, Point e) =>
            points = new Point[] { a, b, c, d, e };

        #endregion

        public void PerimeterCalculator()
        {
            // Вычисление имени фигуры
            string name = default;

            switch (points.Length)
            {
                case 3:
                    name = "Треугольник";
                    break;

                case 4:
                    name = "Прямоугольник";
                    break;

                case 5:
                    name = "Пятиугольник";
                    break;
            }

            // Получение периметра
            double perimeter = 0;

            for (int i = 0; i < points.Length; i++)
            {
                // Проверяем, является ли точка последней.
                // Если да - нужно высчитать длину между последней точкой и первой.
                // Причина - фигура закрытая, тоесть все точки соединены между собой
                if (i == points.Length - 1)
                    perimeter += LengthSide(points[i], points[0]);
                else
                    perimeter += LengthSide(points[i], points[i + 1]);
            }

            Console.WriteLine($"{name} имеет длину периметра {perimeter}");
        }

        // Метод приватный, так как нужен только для внутренних вычислений
        // Декартово вычисление расстояния между точками
        double LengthSide(Point a, Point b) =>
            Math.Sqrt(Math.Pow(a.X - b.X, 2) + Math.Pow(a.Y - b.Y, 2));
    }
}
