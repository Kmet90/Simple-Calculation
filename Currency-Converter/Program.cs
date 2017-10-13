using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Currency_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            string currency1 = Console.ReadLine();
            string currency2 = Console.ReadLine();
            double rate = 0.0;
            double newRate = 0.0;

            if (currency1 == "BGN") rate = 1;
            else if (currency1 == "USD") rate = 1.79549;
            else if (currency1 == "EUR") rate = 1.95583;
            else if (currency1 == "GBP") rate = 2.53405;

            if (currency2 == "BGN") newRate = 1;
            else if (currency2 == "USD") newRate = 1.79549;
            else if (currency2 == "EUR") newRate = 1.95583;
            else if (currency2 == "GBP") newRate = 2.53405;

            var result = money * rate / newRate;

            Console.WriteLine("{0} {1}", Math.Round(result,2), currency2);

        } 
    }
}
