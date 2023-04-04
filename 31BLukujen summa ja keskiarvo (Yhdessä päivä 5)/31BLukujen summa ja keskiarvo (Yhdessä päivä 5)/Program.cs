using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31BLukujen_summa_ja_keskiarvo__Yhdessä_päivä_5_
{
    class Program
    {
        static void Main(string[] args)
        {//31B C# Toisto: Lukujen summa ja keskiarvo (Yhdessä päivä 5)
         //Kirjoita ohjelma, joka kysyy käyttäjältä laskettavien lukujen määrän. Ohjelma pyytää lukuja annetun luvun verran. Lopussa sovellus näyttää lukujen summan ja keskiarvon

            Console.Write("Montako lukua summataan: ?");

            int loops = int.Parse(Console.ReadLine());
            int numbersToSum = int.Parse(Console.ReadLine());
            double sum = 0;

            for(int i = 0; i < numbersToSum; i++)
            {
                Console.Write($"Anna luku {i}: );

                sum = sum + int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"Summa on: {sum} ja summan keskiarvo on:{sum/numbersToSum}");



            Console.ReadKey();



        }
    }
}
