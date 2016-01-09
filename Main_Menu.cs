/*
========================================
Title: Case 2
Created by: Christian H. L., Christian L., Kenneth H. & Frederik
========================================
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //cmd title
            Console.Title = "Case 2";

            //variables
            string menu;

            //gudie to what user can do in program
            Console.Write("Velkommen til info skræmen bruger.\n\nvalg et punkt ved at trykke 1 , 2 , 3 , 4\n\n");
            Console.Write("1. Temperaturmåler.\n2.Valutaberegner\n3. Programoversigt.\nValgfri emne.")
            menu = Console.ReadLine();

            //user info make action
            switch (menu)
            {
                case "1":
                    Console.WriteLine("Temperaturmåler");
                    break;
                case "2":
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("valutaberegner"); ;
                    break;
                case "3":
                    Console.WriteLine("Programoversigt"); ;
                    break;
                case "4":
                    Console.WriteLine("Valgfri emne"); ;
                    break;
                    

            }

            //
            Console.ReadKey();

        }
        static void Temperatur_Converter()
        {
            //code for the Temperatur converter
        }
        static void Valuta_Converter()
        {
            //code for the Valuta Converter
        }
        static void Program_Content()
        {
            //code for the Program content 
        }
        static void FreeToChooseTopic()
        {
            //code for the Free to choose topic
        }
    }
}

