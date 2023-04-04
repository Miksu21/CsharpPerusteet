using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30c_Kertymä
{
    class Program
    {
        static void Main(string[] args)
        {//30C C# Toisto: Kertymä (Yhdessä päivä 5)
            Console.Write("Syötä kierroslukumäärä: ");
            int loops = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 0; i < loops; i++)
            {
                sum = sum + i;

            }
            Console.WriteLine($"{loops} kierrosta kertymäksi saatiin: {sum}");


               
        }
    }
}
