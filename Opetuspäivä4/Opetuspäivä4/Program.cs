using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opetuspäivä4
{
    class Program
    {
        static void Main(string[] args)
        {
            DayOfWeek currentDayOfWeekIF = DateTime.Now.DayOfWeek;

            if (currentDayOfWeekIF == DayOfWeek.Saturday)
            {
                Console.WriteLine("Aukioloaika: 10:00 21:00");
            }
            else if (currentDayOfWeekIF == DayOfWeek.Sunday)
            {
                Console.WriteLine("Aukioloaika: 10:00 - 20:00");
            }
            else
            {
                Console.WriteLine("Aukioloaika: 7:00 - 21:00" );

            }
        }
    }
}
