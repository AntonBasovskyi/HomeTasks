using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_5_Task_2
{
    class Store
    {
        private Article[] articles;

        public Store(Article[] articles) =>
            this.articles = articles;

        public int Length => articles.Length;

        public Article this[int index]
        {
            get
            {
                if (index >= 0 && index < articles.Length)
                    return articles[index];
                else
                    return null;
            }

            set
            {
                if (index >= 0 && index < articles.Length)
                    articles[index] = value;
            }
        }
    }

}
