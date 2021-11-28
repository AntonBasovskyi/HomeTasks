using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Создайте класс MyClass и структуру MyStruct, которые содержат в себе поля public string change.
В классе Program создайте два метода:
- static void ClassTaker(MyClass myClass), который присваивает полю change экземпляра
myClass значение «изменено».
- static void StruktTaker(MyStruct myStruct), который присваивает полю change экземпляра
myStruct значение «изменено».
Продемонстрируйте разницу в использовании классов и структур, создав в методе Main() экземпляры
структуры и класса. Измените, значения полей экземпляров на «не изменено», а затем вызовите методы
ClassTaker и StruktTaker. Выведите на экран значения полей экземпляров. Проанализируйте
полученные результаты.
 */

namespace Lesson_7_Task_2
{
    class MyClass
    {
        public string change;
    }

    // В структурах нельзя инициализировать поля непосредственно в месте создания.
    struct MyStruct
    {
        public string change;
    }

    class Program
    {
        static void ClassTaker(MyClass myClass)
        {
            myClass.change = "Изменено";
            Console.WriteLine(myClass.change);
        }

        static void StructTaker(MyStruct myStruct)
        {
            myStruct.change = "Изменено";
            Console.WriteLine(myStruct.change);
        }

        static void Main(string[] args)
        {

            MyStruct myStruct; // конструктор не вызывается.
            myStruct.change = "Не изменено"; // без инициализации поля будет выдавать ошибку. 
            Console.WriteLine(myStruct.change);

            MyClass myClass = new MyClass();
            myClass.change = "Не изменено";
            Console.WriteLine(myClass.change);

            ClassTaker(myClass);
            StructTaker(myStruct);

            Console.ReadKey();
        }
    }
}
