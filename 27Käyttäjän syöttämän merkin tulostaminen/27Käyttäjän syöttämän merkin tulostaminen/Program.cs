using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27Käyttäjän_syöttämän_merkin_tulostaminen
{
    class Program
    {
        static void Main(string[] args)
        {// Käyttäjän syöttämä merkki
            Console.Write("Syötä numero: ");
            int number = int.Parse(Console.ReadLine());

            Console.Write("Syötä merkki: ");
            char cMerkki = char.Parse( Console.ReadLine());

            int i = 1;
            for(i = 1; i<= number; i++)
            {
              Console.WriteLine(cMerkki);

            }
            Console.WriteLine();



            Console.ReadKey();


        }
    }
}
