using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program_oversigt
{
    class Program
    {
        static void Main(string[] args)
        {
            //not done yet no hate AND dont touch it :)

            string[] names = { "Ac/dc", "Justin biber" , "Eminem" };
            string[] time = { "16.00 kl" , "20.00 kl" , "24.00 kl" };
            string[] display = new string[3];

            for (int i = 0; i < display.Length; i++)
            {
                Console.WriteLine(names[i]);
            }

            Console.ReadKey();

        }
    }
}
