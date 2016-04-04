/*
=========================
ADD A HEADER
=========================
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case.valutaberegner
{
    class Program
    {
        static void Main(string[] args)
        {
           double Beløb_DKK = 0, Beløb_USD = 0, Beløb_Euro = 0;

            string valg;
            


            Console.Write("Valg af converter \n \n1. convert DKK til USD og Euro. \n2. convert USD til DKK og Euro. \n3. convert Euro til DKK og USD. \n\n");
            valg = Console.ReadLine();
            switch (valg)
            {
                case "1":
                    
                    Console.WriteLine("Hvor mange penge skal conveteres");
                    Beløb_DKK = double.Parse(Console.ReadLine());
                    Beløb_Euro = Beløb_DKK * 0.134;
                    Console.WriteLine(Beløb_Euro + ":" + "EUR");

                    Beløb_USD = Beløb_DKK * 0.146;
                    Console.WriteLine(Beløb_USD + ":"+ "$");

                    break;

                case "2":
                    Console.WriteLine("Hvor mange penge skal der conveteres");
                    Beløb_USD = double.Parse(Console.ReadLine());
                    Beløb_DKK = Beløb_USD * 6.8;
                    Console.WriteLine(Beløb_DKK + ":" + "DKK");

                    Beløb_Euro = Beløb_USD * 0.91;
                    Console.WriteLine(Beløb_Euro + ":" + "EUR");



                    break;

                case "3":
                    Console.WriteLine("Hvor mange penge skal converteres");
                    Beløb_Euro = double.Parse(Console.ReadLine());
                    Beløb_DKK = Beløb_Euro * 7.4;
                    Console.WriteLine(Beløb_DKK + ":" + "DKK");

                    Beløb_USD = Beløb_Euro * 1.08;
                    Console.WriteLine(Beløb_USD + ":" + "$");


                    break;
            }





            Console.ReadKey();

        }
        
        
    }
}
