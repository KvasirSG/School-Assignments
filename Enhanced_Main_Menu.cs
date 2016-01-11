using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu_boxes
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu("Main");
            Console.ReadKey();
        }
        static void box(int x, int y)
        {
            int start_y = 0;
            int mid_window = Console.WindowWidth / 2;
            for (int i = 0; i <= x; i++)
            {
                Console.SetCursorPosition(mid_window - i, start_y);
                box_write("vandret");
                Console.SetCursorPosition(mid_window + i, start_y);
                box_write("vandret");
            }

            for (int i = 1; i <= y; i++)
            {
                Console.SetCursorPosition(mid_window - x, start_y + i);
                box_write("lodret");
                Console.SetCursorPosition(mid_window + x, start_y + i);
                box_write("lodret");
            }
            for (int i = 0; i <= x; i++)
            {
                Console.SetCursorPosition(mid_window - i, start_y + y);
                box_write("vandret");
                Console.SetCursorPosition(mid_window + i, start_y + y);
                box_write("vandret");
            }
            Console.SetCursorPosition(mid_window - x, start_y);
            box_write("tvkant");
            Console.SetCursorPosition(mid_window + x, start_y);
            box_write("thkant");
            Console.SetCursorPosition(mid_window - x, start_y + y);
            box_write("bvkant");
            Console.SetCursorPosition(mid_window + x, start_y + y);
            box_write("bhkant");
        }
        static void Menu(string menu)
        {
            int start_y = 0, x, y;
            int mid_window = Console.WindowWidth / 2;
            string[] Main = { "Temperatur Omregner", "Valuta Omregner", "ProgramOversigt" };
            string title;

            switch (menu)
            {
                case "Main":
                    title = "<Main Menu>";
                    x = 24 / 2;
                    y = 9;
                    int tal = 0;
                    box(x, y);
                    MenuTitle(title, start_y);
                    for (int i = 0; i < 3; i++)
                    {
                        tal = i + 1;
                        Console.SetCursorPosition(mid_window - x + 1, start_y + 3 + (i * 2));
                        Console.Write("{0}. {1}", tal, Main[i]);
                    }
                    MainMenu(x, y, start_y);
                    break;
                default:
                    break;
            }

        }
        static void box_write(string kant)
        {
            string tvkant = "\x250C"; //Top venstre hjørne på ramme

            string thkant = "\x2510"; //Top højre hjørne på ramme

            string bvkant = "\x2514"; //Bund venstre hjørne på ramme

            string bhkant = "\x2518"; //Bund højre hjørne på ramme

            string lodret = "\x2502"; //ramme - lodret

            string vandret = "\x2500"; //ramme - vandret
            switch (kant)
            {
                case "tvkant":
                    Console.Write(tvkant);
                    break;
                case "thkant":
                    Console.Write(thkant);
                    break;
                case "bvkant":
                    Console.Write(bvkant);
                    break;
                case "bhkant":
                    Console.Write(bhkant);
                    break;
                case "lodret":
                    Console.Write(lodret);
                    break;
                case "vandret":
                    Console.Write(vandret);
                    break;
                default:
                    break;
            }
        }
        static void MainMenu(int x, int y, int start_y)
        {
            int mid_window = Console.WindowWidth / 2;
            string valg;
            Console.SetCursorPosition(mid_window - x + 1, y + 2);
            Console.Write("Vælg punkt: ");
            Console.SetCursorPosition(mid_window - x + 1, y + 3);
            valg = Console.ReadLine();
            switch (valg)
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
        }
        static void MenuTitle(string title, int start_y)
        {
            int mid_window = Console.WindowWidth / 2;
            Console.SetCursorPosition(mid_window - (title.Length / 2), start_y + 1);
            Console.Write(title);
        }
    }
}
