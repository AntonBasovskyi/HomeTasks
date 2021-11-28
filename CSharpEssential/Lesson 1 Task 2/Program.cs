using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 Используя Visual Studio, создайте проект по шаблону Console Application.
Требуется:
Создать класс Book. Создать классы Title, Author и Content, каждый из которых должен содержать
одно строковое поле и метод void Show().
Реализуйте возможность добавления в книгу названия книги, имени автора и содержания.
Выведите на экран разными цветами при помощи метода Show() название книги, имя автора и
содержание. 
 */
namespace Lesson_1_Task_2
{
    class Book
    {
        public Title title;
        public Author author = null;
        public Content content = null;

        public Book(string titleText) =>
            title = new Title(titleText);

        public Book(string titleText, string authorText)
            : this(titleText) => author = new Author(authorText);

        public Book(string titleText, string authorText, string contentText)
            : this(titleText, authorText) => content = new Content(contentText);

        public void Show()
        {
            title.Show();

            if (author != null)
                author.Show();

            if (content != null)
                content.Show();
        }
    }

    class Title
    {
        string title;

        public Title(string title) =>
            this.title = title;

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write($"Название книги: {title}, ");
        }
    }

    class Author
    {
        string author;

        public Author(string author) =>
            this.author = author;

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write($"имя автора: {author}, ");
        }
    }

    class Content
    {
        string content;

        public Content(string content) =>
            this.content = content;

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write($"содержание книги: {content}.");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите название книги: ");
            string titleText = Console.ReadLine();
            
            Console.Write("Введите автора книги: ");
            string author = Console.ReadLine();
            
            Console.Write("Введите текст книги: ");
            string content = Console.ReadLine();

            Book book = new Book(titleText, author, content);
            book.Show();

            Console.ReadKey();
        }
    }
}
