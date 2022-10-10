using System;


namespace CounterTask
{
    public class MainClass
    {

        //Main method
        public static void Main(string[] args)
        {
            // creating counters array of size 3
            Counter[] myCounters = new Counter[3];

            // initializing myCounter
            myCounters[0] = new Counter("Counter 1");
            myCounters[1] = new Counter("Counter 2");
            myCounters[2] = myCounters[0];

            //looping to Increment Counter1
            for (int i = 0; i <= 4; ++i)
                myCounters[0].Increment();

            //looping to Increment Counter2
            for (int i = 0; i <= 9; ++i)
                myCounters[1].Increment();

            //PrintCounters method
            MainClass.PrintCounters(myCounters);

            //resetting myCounters[2]
            myCounters[2].Reset();

            MainClass.PrintCounters(myCounters);

            Console.ReadLine();
        }

        private static void PrintCounters(Counter[] counters) //PrintCounter Static Method | Q10
        {
            foreach (Counter count in counters)
            {
                Console.WriteLine("{0} is {1}", count.Name, count.Tick);
            }
        }


    }
}

