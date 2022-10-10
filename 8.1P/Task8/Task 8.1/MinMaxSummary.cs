using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_8._1
{
    public class MinMaxSummary : SummaryStrategy
    {
        private int Minimum(List<int> numbers)
        {
            return numbers.Min();
        }

        private int Maximum(List<int> numbers)
        {
            return numbers.Max();
        }

        public override void PrintSummary(List<int> number)
        {
            Console.WriteLine("Min number is {0}", Minimum(number));
            Console.WriteLine("Max number is {0}", Maximum(number));
        }
    }
}
