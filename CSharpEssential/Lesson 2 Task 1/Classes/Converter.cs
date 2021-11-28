using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2_Task_1.Classes
{
    class Converter
    {
        const string uahCode = "uah";
        const string uahName = "гривна";

        double usd;
        const string usdCode = "usd";
        const string usdName = "доллар";

        double eur;
        const string eurCode = "eur";
        const string eurName = "евро";

        double rub;
        const string rubCode = "rub";
        const string rubName = "рубль";
        public Converter(double usd, double eur, double rub)
        {
            this.usd = usd;
            this.eur = eur;
            this.rub = rub;
        }

        public double Convert(double amount, string fromCurrency, string toCurrency)
        {
            bool convertFromGrivna = toCurrency == uahCode || toCurrency == uahName;
            bool convertToGrivna = fromCurrency == uahCode || fromCurrency == uahName;

            if (!convertFromGrivna && !convertToGrivna)
                return -1;

            double convertedValue = 0;
            if (convertFromGrivna)
            {
                switch (fromCurrency)
                {
                    case usdCode:
                    case usdName:
                        convertedValue = amount * usd;
                        break;
                    case eurCode:
                    case eurName:
                        convertedValue = amount * eur;
                        break;
                    case rubCode:
                    case rubName:
                        convertedValue = amount * rub;
                        break;
                }


            }
            else
            {
                // Convert from some currency to grivna
                switch (toCurrency)
                {
                    case usdCode:
                    case usdName:
                        convertedValue = amount / usd;
                        break;
                    case eurCode:
                    case eurName:
                        convertedValue = amount / eur;
                        break;
                    case rubCode:
                    case rubName:
                        convertedValue = amount / rub;
                        break;
                }
            }

            return convertedValue;
        }
    }
}
