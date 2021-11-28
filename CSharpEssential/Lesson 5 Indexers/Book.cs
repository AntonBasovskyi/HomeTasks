using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
    Расширьте пример 5 (русско-английский словарь) еще и украинским словарем. Реализуйте возможность
    поиска не только по ключевым русским словам и словам на остальных языках.
 */
namespace Lesson_5_Indexers
{
    class Book
    {
        readonly string[] russian = new string[5];
        readonly string[] english = new string[5];
        readonly string[] ukranian = new string[5];

        public Book()
        {
            russian[0] = "книга"; english[0] = "book"; ukranian[0] = "книга";
            russian[1] = "ручка"; english[1] = "pen"; ukranian[1] = "ручка";
            russian[2] = "солнце"; english[2] = "sun"; ukranian[2] = "сонце";
            russian[3] = "яблоко"; english[3] = "apple"; ukranian[3] = "яблуко";
            russian[4] = "стол"; english[4] = "table"; ukranian[4] = "стіл";
        }

        public string this[string index]
        {
            get
            {
                for (int i = 0; i < russian.Length; i++)
                    if (russian[i] == index || ukranian[i] == index || english[i] == index)
                        return $"{russian[i]} - {ukranian[i]} - {english[i]}";

                return $"{index} - нет перевода для этого слова.";
            }
        }
    }
}
