using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_5_Task_2
{
    class Article
    {
        public string ProductName { get; }
        public string NameOfStore { get; }
        public int ProductPriceUah { get; }

        public Article(string productName, string nameOfStore, int productPriceUah) =>
            (ProductName, NameOfStore, ProductPriceUah) = (productName, nameOfStore, productPriceUah);
    }

}
