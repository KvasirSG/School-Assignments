using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case_Tempaturmåler
{
    class Program
    {
        static void Main(string[] args)
        {
            Temperatur_converter();

        }
        static void Temperatur_converter()
        {
            double fahrenheit = 33.8;
            double celsius = 0;
            string valg;
            double ny_celsius;

            Console.Write("Valg af Converter \n \n1. Convert Celcius to fahrenheit.\n2. Convert fahrenheit to Celcius.\n\n");
            valg = Console.ReadLine();
            switch (valg)
            {
                case "1":
                    
                    celsius = double.Parse(Console.ReadLine());
                    fahrenheit = celsius * 9 / 5 + 32;
                    Console.WriteLine(fahrenheit);
                    
                    break;

                case "2":

                    //celsius
                    break;
                //default:
            }
            Console.ReadKey();
        }
    }
}
