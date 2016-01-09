/*
=================================
ADD A HEADER!!!
=================================
*/
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
            //Variables
            double fahrenheit = 0;
            double celsius = 0;
            string valg="",Degree_Symbol="\u00B0";
            double ny_celsius;
            
            //code
            Console.Write("Valg af Converter \n \n1. Convert Celcius to fahrenheit.\n2. Convert fahrenheit to Celcius.\n\n");
            valg = Console.ReadLine();
            switch (valg)
            {
                case "1":
                    Console.WriteLine("Type {0}C:",Degree_Symbol);
                    celsius = double.Parse(Console.ReadLine());
                    fahrenheit = celsius * (9 / 5) + 32;
                    Console.WriteLine("{0}{1}F",fahrenheit,Degree_Symbol);
                    
                    break;

                case "2":
                    Console.WriteLine("Type {0}F:",Degree_Symbol);
                    celsius = double.Parse(Console.ReadLine());
                    celsius = (fahrenheit - 32) * (5/9);
                    Console.WriteLine("{0}{1}C",celsius,Degree_Symbol);
                    break;
                //default:
            }
            Console.ReadKey();
        }
    }
}
