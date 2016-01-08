/*
========================================
Title: Case 2
Created by: Christian H.L, Christian L, Kenneth H. &
Frederik 2.
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
            Console.WriteLine("Velkommen til info skræmen bruger. valg et punkt ved at trykke 1 , 2 , 3 , 4");
            Console.WriteLine("");
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
    }
}

