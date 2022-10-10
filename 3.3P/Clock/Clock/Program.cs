using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clock
{
    public class Program
    {
        static void Main()
        {
            Clock TheClock = new Clock();
            for (int c = 0; c < 10000; c++)
            {
                TheClock.Tick();
            }
            Console.WriteLine("Displays Time as : {0} ", TheClock.time);
            
        }
    }
}
