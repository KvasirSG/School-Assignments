/*
=================================
Title: Case 2
Created by: Christian H. L., Christian L., Kenneth H. & Frederik W.
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
            double fahrenheit = 33.8;
            double celsius = 0;
            string valg="",temperatur_symbol="\u00B0";
            

            Console.Write("Valg af Converter \n \n1. Convert Celcius to fahrenheit.\n2. Convert fahrenheit to Celcius.\n\n");
            valg = Console.ReadLine();
            switch (valg)
            {
                case "1":

                    Console.WriteLine("Indtast {0}C:", temperatur_symbol);
                    celsius = double.Parse(Console.ReadLine());
                    fahrenheit = celsius * 9 / 5 + 32;
                    Console.WriteLine(fahrenheit + "°F");
                    

                    break;

                case "2":
                    Console.WriteLine("Indtast {0}F:", temperatur_symbol);
                    fahrenheit = double.Parse(Console.ReadLine());
                    celsius = (fahrenheit - 32) * 5 / 9;
                    Console.WriteLine(celsius + "°C");

                    //celsius
                    break;
                //default:
            }
            Console.ReadKey();
        }
    }
}
