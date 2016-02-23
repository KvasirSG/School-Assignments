/*
================================================
Title: Case2
Created by: Kenneth H., Christian H. L., Christian L. and Frederik W.
Edited and corrected by Flix aka TheMasterCoder and Anastasiya aka Tasiya
================================================
*/
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
            Console.CursorVisible = false;
            Menu("Main");
            Console.ReadKey();
        }
        //box creation code
        static void box(int start_y, int x, int y)// x,y = hight and width of the box preset the box from top --default at 0
        {
            //variables
            int mid_window = Console.WindowWidth / 2; // the center of the box

            //code
            //top line
            for (int i = 0; i <= x; i++)
            {
                Console.SetCursorPosition(mid_window - i, start_y); //top left line
                box_write("vandret");
                Console.SetCursorPosition(mid_window + i, start_y); //top right line
                box_write("vandret");
            }

            //right and left line
            for (int i = 1; i <= y; i++)
            {
                Console.SetCursorPosition(mid_window - x, start_y + i); //left line
                box_write("lodret");
                Console.SetCursorPosition(mid_window + x, start_y + i); //right line
                box_write("lodret");
            }

            // bottom line
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
        //Menu
        static void Menu(string menu)
        {
            //variables
            int start_y = 0, x, y;
            int mid_window = Console.WindowWidth / 2;
            int tal = 0;
            string[] Main = { "Temperatur Omregner", "Valuta Omregner", "ProgramOversigt", "Location" }; //array for main menu
            string[] Temp_Conv = { "Convert Celcius to fahrenheit.", "Convert fahrenheit to Celcius." };
            string[] Valu_Conv = { "convert DKK til USD og Euro.", "Convert USD til DKK og Euro.", "Convert Euro til DKK og USD." };
            string[] oversigt_names = { "Ac/dc", "Justin biber", "Eminem" };
            string[] oversigt_time = { "16.00 kl", "20.00 kl", "24.00 kl" };
            string[] location = { "Pavilion","Arena","Avalon","Orange scene", "?????"};
            string[] Menu_item;
            string title; //name the menu

            switch (menu)
            {
                case "Main":
                    Console.Clear();
                    title = "<Main Menu>";
                    Menu_item = Main;
                    x = 30 / 2;
                    y = Menu_item.Length * 2 + 3;
                    box(start_y, x, y); //draw the box
                    MenuTitle(title, start_y); //set the title

                    // placing the menu array
                    for (int i = 0; i < Menu_item.Length; i++)
                    {
                        tal = i + 1;
                        Console.SetCursorPosition(mid_window - x + 1, start_y + 3 + (i * 2));
                        Console.Write("{0}. {1}", tal, Menu_item[i]);
                    }
                    box(y + 2, 2, 2);
                    MainMenu(x, y, y + 3);
                    break;
                case "Temp_Conv":
                    Console.Clear();
                    title = "<Temperatur Converter>";
                    Menu_item = Temp_Conv;
                    x = 36 / 2;
                    y = Menu_item.Length * 2 + 3;
                    box(start_y, x, y); //draw the box
                    MenuTitle(title, start_y); //set the title

                    for (int i = 0; i < Menu_item.Length; i++)
                    {
                        tal = i + 1;
                        Console.SetCursorPosition(mid_window - x + 1, start_y + 3 + (i * 2));
                        Console.Write("{0}. {1}", tal, Menu_item[i]);
                    }
                    box(y + 2, 2, 2);
                    Temperatur_converter(x, y, y + 3);
                    break;
                case "Valu_Conv":
                    Console.Clear();
                    title = "<Valuta Converter>";
                    Menu_item = Valu_Conv;
                    x = 36 / 2;
                    y = Menu_item.Length * 2 + 3;
                    box(start_y, x, y); //draw the box
                    MenuTitle(title, start_y); //set the title

                    for (int i = 0; i < Menu_item.Length; i++)
                    {
                        tal = i + 1;
                        Console.SetCursorPosition(mid_window - x + 1, start_y + 3 + (i * 2));
                        Console.Write("{0}. {1}", tal, Menu_item[i]);
                    }
                    box(y + 2, 2, 2);
                    valu_conv(x, y, y + 3);
                    break;
                case "Pro_Ove":
                    Console.Clear();
                    title = "<ProgramOversigt>";
                    Menu_item = oversigt_names;
                    x = 30 / 2;
                    y = Menu_item.Length * 2 + 3;
                    box(start_y, x, y); //draw the box
                    MenuTitle(title, start_y); //set the title

                    for (int i = 0; i < Menu_item.Length; i++)
                    {
                        tal = i + 1;
                        Console.SetCursorPosition(mid_window - x + 1, start_y + 3 + (i * 2));
                        Console.Write(oversigt_names[i] + " : " + oversigt_time[i]);
                    }
                    Console.ReadKey();
                    Menu("Main");
                    break;
                case "valgfri_emne":
                    Console.Clear();
                    title = "<Location>";
                    Menu_item = location;
                    x = 30 / 2;
                    y = Menu_item.Length * 2 + 3;
                    box(start_y, x, y); //draw the box
                    MenuTitle(title, start_y); //set the title

                    // placing the menu array
                    for (int i = 0; i < Menu_item.Length; i++)
                    {
                        tal = i + 1;
                        Console.SetCursorPosition(mid_window - x + 1, start_y + 3 + (i * 2));
                        Console.Write("{0}. {1}", tal, Menu_item[i]);
                    }
                    box(y + 2, 2, 2);
                    Console.SetCursorPosition(mid_window, y+3);
                    string sum;
                    sum = (Console.ReadLine());
                    Console.Clear();
                    switch (sum)
                    {
                        case "1":
                            Console.WriteLine("\n :Wc er 200m fra dig \n :Orange scene er 400m nær dig \n :øl bod er 900m er nær dig  ");
                            break;
                        case "2":
                            Console.WriteLine("\n :Wc er 600m fra dig \n :Orange scene er 200m nær dig \n :øl bod er 100m er nær dig");
                            break;
                        case "3":
                            Console.WriteLine("\n :Wc er 700m fra dig \n :Orange scene er 600m nær dig \n :øl bod er 300m er nær dig");
                            break;
                        case "4":
                            Console.WriteLine("\n :Wc er 500m fra dig \n :Orange scene er 0m nær dig \n :øl bod er 100m er nær dig");
                            break;
                        case "5":
                            Console.WriteLine("\n :?????");
                            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=dQw4w9WgXcQ");
                            break;
                        default:
                            break;
                    }
                    Console.ReadKey();
                    Menu("Main");
                    break;
                default:
                    break;
            }

        }
        //define the code for the lines
        static void box_write(string kant)
        {
            string tvkant = "\x250C"; //Top left corner of the frame

            string thkant = "\x2510"; //Top right corner of the frame

            string bvkant = "\x2514"; //Bottom left corner of the frame

            string bhkant = "\x2518"; //Bottom right corner of the frame

            string lodret = "\x2502"; //Frame line - vertical

            string vandret = "\x2500"; //Frame line - Horizontal
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

        //main menu choose options
        static void MainMenu(int x, int y, int start_y)
        {
            int mid_window = Console.WindowWidth / 2;
            string valg;
            Console.SetCursorPosition(mid_window - x + 1, y + 1);
            Console.Write("Vælg punkt: ");
            Console.SetCursorPosition(mid_window, start_y);
            valg = Console.ReadLine();
            switch (valg)
            {
                case "1":
                    Menu("Temp_Conv");
                    break;
                case "2":
                    Menu("Valu_Conv");
                    break;
                case "3":
                    Menu("Pro_Ove");
                    break;
                case "4":
                    Menu("valgfri_emne");
                    break;
            }
        }
        //sets the title in top middle of the box
        static void MenuTitle(string title, int start_y)
        {
            int mid_window = Console.WindowWidth / 2;
            Console.SetCursorPosition(mid_window - (title.Length / 2), start_y + 1);
            Console.Write(title);
        }
        static void Temperatur_converter(int x, int y, int start_y)
        {
            double fahrenheit = 33.8;
            double celsius = 0;
            string valg = "", temperatur_symbol = "\u00B0";
            int mid_window = Console.WindowWidth / 2;

            Console.SetCursorPosition(mid_window - x + 1, y + 1);
            Console.Write("Vælg Converter: ");
            Console.SetCursorPosition(mid_window, start_y);

            valg = Console.ReadLine();
            switch (valg)
            {
                case "1":
                    Console.Clear();
                    box(0, 7, 10);
                    Console.SetCursorPosition(mid_window - 4, 1);
                    Console.WriteLine("Indtast{0}C", temperatur_symbol);
                    box(2, 4, 2);
                    Console.SetCursorPosition(mid_window - 3, 3);
                    celsius = double.Parse(Console.ReadLine());
                    fahrenheit = celsius * 9 / 5 + 32;
                    Console.SetCursorPosition(mid_window - 4, 5);
                    Console.WriteLine("Resultat:");
                    box(6, 6, 2);
                    Console.SetCursorPosition(mid_window - 2, 7);
                    Console.WriteLine("{0}{1}F", fahrenheit, temperatur_symbol);


                    break;

                case "2":
                    Console.Clear();
                    box(0, 7, 10);
                    Console.SetCursorPosition(mid_window - 4, 1);
                    Console.WriteLine("Indtast{0}F", temperatur_symbol);
                    box(2, 4, 2);
                    Console.SetCursorPosition(mid_window - 3, 3);
                    fahrenheit = double.Parse(Console.ReadLine());
                    celsius = (fahrenheit - 32) * 5 / 9;
                    box(2, 4, 2);
                    Console.SetCursorPosition(mid_window - 4, 5);
                    Console.WriteLine("Resultat:");
                    box(6, 6, 2);
                    Console.SetCursorPosition(mid_window - 4, 7);
                    Console.WriteLine("{0:N2}{1}C", celsius, temperatur_symbol);

                    //celsius
                    break;
                    //default:
            }
            Console.ReadKey();
            Menu("Main");
        }
        static void valu_conv(int x, int y, int start_y)
        {
            double Beløb_DKK = 0, Beløb_USD = 0, Beløb_Euro = 0;
            int mid_window = Console.WindowWidth / 2;
            string valg;

            Console.SetCursorPosition(mid_window - x + 1, y + 1);
            Console.Write("Vælg Converter: ");
            Console.SetCursorPosition(mid_window, start_y);

            valg = Console.ReadLine();
            switch (valg)
            {
                case "1":

                    Console.Clear();
                    box(0, 8, 15);
                    Console.SetCursorPosition(mid_window - 5, 1);
                    Console.WriteLine("Beløb i DKK:");
                    box(2, 4, 2);
                    Console.SetCursorPosition(mid_window - 3, 3);
                    Beløb_DKK = double.Parse(Console.ReadLine());

                    Beløb_Euro = Beløb_DKK * 0.134;
                    Console.SetCursorPosition(mid_window - 5, 6);
                    Console.WriteLine("Euro:");
                    box(7, 6, 2);
                    Console.SetCursorPosition(mid_window - 4, 8);
                    Console.WriteLine("{0:N2} EUR", Beløb_Euro);
                    Console.SetCursorPosition(mid_window - 5, 10);
                    Console.WriteLine("US Dollar:");
                    box(11, 6, 2);
                    Console.SetCursorPosition(mid_window - 4, 12);
                    Beløb_USD = Beløb_DKK * 0.146;
                    Console.WriteLine("{0:N2} USD", Beløb_USD);
                    break;

                case "2":
                    Console.Clear();
                    box(0, 8, 15);
                    Console.SetCursorPosition(mid_window - 5, 1);
                    Console.WriteLine("Beløb USD:");
                    box(2, 4, 2);
                    Console.SetCursorPosition(mid_window - 3, 3);
                    Beløb_USD = double.Parse(Console.ReadLine());
                    Beløb_DKK = Beløb_USD * 6.8;
                    Console.SetCursorPosition(mid_window - 6, 6);
                    Console.WriteLine("Danske Kroner:");
                    box(7, 6, 2);
                    Console.SetCursorPosition(mid_window - 4, 8);
                    Console.WriteLine("{0:N2} DKK", Beløb_DKK);
                    Console.SetCursorPosition(mid_window - 5, 10);
                    Console.WriteLine("Euro:");
                    box(11, 6, 2);
                    Console.SetCursorPosition(mid_window - 4, 12);
                    Beløb_Euro = Beløb_USD * 0.91;
                    Console.WriteLine("{0:N2} EUR", Beløb_Euro);
                    break;

                case "3":
                    Console.Clear();
                    box(0, 8, 15);
                    Console.SetCursorPosition(mid_window - 5, 1);
                    Console.WriteLine("Beløb EUR:");
                    box(2, 4, 2);
                    Console.SetCursorPosition(mid_window - 3, 3);
                    Beløb_Euro = double.Parse(Console.ReadLine());
                    Beløb_DKK = Beløb_Euro * 7.4;
                    Console.SetCursorPosition(mid_window - 6, 6);
                    Console.WriteLine("Danske Kroner:");
                    box(7, 6, 2);
                    Console.SetCursorPosition(mid_window - 4, 8);
                    Console.WriteLine("{0:N2} DKK", Beløb_DKK);
                    Console.SetCursorPosition(mid_window - 5, 10);
                    Console.WriteLine("US Dollar:");
                    box(11, 6, 2);
                    Console.SetCursorPosition(mid_window - 4, 12);
                    Beløb_USD = Beløb_Euro * 1.08;
                    Console.WriteLine("{0:N2} USD", Beløb_USD);
                    break;
            }
            Console.ReadKey();
            Menu("Main");
        }
    }

}
