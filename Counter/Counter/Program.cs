using System;

namespace CounterApp
{
    public class Program
    {
        // Counter Method
        private static void PrintCounters(Counters[] counters)
        {
            foreach (Counters count in counters)
            {
                Console.WriteLine("{0} is {1}", count.Name, count.Value);
            }
        }

        // Main Method
        public static void Main(string[] args)
        {
            Counters[] mycounter = new Counters[3];

            mycounter[0] = new Counters("Counter 1");
            mycounter[1] = new Counters("Counter 2");
            mycounter[2] = mycounter[0];

            for (int i = 0; i < 4; ++i)
            {
                mycounter[1].Increament();
            }

            Program.PrintCounters(mycounter);

            mycounter[2].reset();

            Program.PrintCounters(mycounter);

            Console.ReadLine();
        }
    }

    class Counters 
    {
        private string _name;
        private int _count;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
    }
}