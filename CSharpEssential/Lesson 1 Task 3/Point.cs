/*
 Используя Visual Studio, создайте проект по шаблону Console Application.
Требуется:
Создать классы Point и Figure.
Класс Point должен содержать два целочисленных поля и одно строковое поле.
Создать три свойства с одним методом доступа get.
Создать пользовательский конструктор, в теле которого проинициализируйте поля значениями
аргументов. Класс Figure должен содержать конструкторы, которые принимают от 3-х до 5-ти
аргументов типа Point.
Создать два метода: double LengthSide(Point A, Point B), который рассчитывает длину
стороны многоугольника; void PerimeterCalculator(), который рассчитывает периметр
многоугольника.
Написать программу, которая выводит на экран название и периметр многоугольника. 
 */
namespace Lesson_1_Task_3
{
    class Point
    {
        int a;
        int b;
        string c;
        public int x => a;
        public int y => b;
        public string z => c;

        public Point(int a, int b, string c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
    }
}
