using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opetuspäivä_5
{
    class Program
    {
        static void Main(string[] args)
        {//Toisto: Parillinen Pariton 28 c#

            Console.Write("Syötä luku johon asti tulostetaan: ");
            int number = int.Parse(Console.ReadLine());

            int i = 1;

            Console.Write("Parillinen / Pariton: ");
            string input = Console.ReadLine();


            while (i <= number)
            {
                if (i % 2 != 0 && input == "Pariton")

                {
                    Console.WriteLine(i);
                }
                i++;


            }
            Console.ReadKey();




        }
    }
}
