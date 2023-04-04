using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kuukaudet__yhdessä_3._4._
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Mikä kuukausi nyt on?");
            string sKuukausi = Console.ReadLine();
            sKuukausi = sKuukausi.ToLower();

            

            if (sKuukausi == "joulukuu" || sKuukausi == "marraskuu" || sKuukausi == "tammikuu" || sKuukausi == "helmikuu" || sKuukausi == "maaliskuu")

            {
                Console.WriteLine("Nyt on talvi");

            }
            else if (sKuukausi == "huhtikuu" || sKuukausi == "toukokuu")
            {
                Console.WriteLine("Nyt on kevät");
            }
            else if (sKuukausi == "kesäkuu" || sKuukausi == "heinäkuu" || sKuukausi == "elokuu")
            {
                Console.WriteLine("Nyt on kesä");
            }
            else if (sKuukausi == "syyskuu" || sKuukausi == "lokakuu")
            {
                Console.WriteLine("Nyt on syksy");

            }
            Console.Write("Anna kuukausi numeroina: ");
            int monthSwitch = int.Parse(Console.ReadLine());
            switch (monthSwitch)
            {
                case 11:
                case 12:
                case 1:
                case 2:
                case 3:
                    Console.WriteLine("Nyt on talvi");
                    break;

                case 4:
                case 5:
                    Console.WriteLine("Nyt on kevät");
                    break;

                case 6:
                case 7:
                case 8:
                    
                    Console.WriteLine("Nyt on kesä");
                    break;

                default:

                    Console.WriteLine("Nyt on syksy");
                    break;

            }

            //ternary versio
            Console.Write("Anna kuukausi numerona:");
            int monthTernary = int.Parse(Console.ReadLine());

            string message = "";

            // ternary vertailu
            message = monthTernary == 11 || monthTernary == 12 || monthTernary >= 1 && monthTernary <= 3 ? "Talvi" :
            monthTernary >= 4 && monthTernary <= 5 ? "Kevät" :
            monthTernary >= 6 && monthTernary <= 8 ? "Kesä" :
            monthTernary >= 9 && monthTernary <= 10 ? "Syksy" :
            "Virheellinen arvo";

            Console.WriteLine(message);











































            



        }
    }
}
