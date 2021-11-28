using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_6_Task_1
{
    class Book
    {
        readonly string[] russian = new string[5];
        readonly string[] english = new string[5];
        readonly string[] ukranian = new string[5];

        public Book()
        {
            russian[0] = "книга"; ukranian[0] = "книга"; english[0] = "book";
            russian[1] = "ручка"; ukranian[1] = "ручка"; english[1] = "pen";
            russian[2] = "солнце"; ukranian[2] = "сонце"; english[2] = "sun";
            russian[3] = "яблоко"; ukranian[3] = "яблуко"; english[3] = "apple";
            russian[4] = "стол"; ukranian[4] = "стіл"; english[4] = "table";
        }

        public string this[string index]
        {
            get
            {
                for (int i = 0; i < russian.Length; i++)
                {
                    if (russian[i] == index || ukranian[i] == index || english[i] == index)
                    {
                        return "Русский|Украинский|Английский\n" +
                              $"{russian[i]}  -  {ukranian[i]}  -  {english[i]}";
                    }
                }
                    
                return $"{index} - нет перевода для этого слова.";
            }
        }
    }
}
