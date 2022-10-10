using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_8._1
{
    public class AverageSummary : SummaryStrategy
    {
        private float Average(List<int> numbers)
        {
            int total = 0;
            foreach (int number in numbers)
            {
                total += number;
            }
            return total / numbers.Count;
        }

        public override void PrintSummary(List<int> numbers)
        {
            Console.WriteLine("Average is {0}", Average(numbers));
        }

    }
}
