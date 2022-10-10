using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_8._1
{
    public class Program
    {
        static void Main()
        {
            
            
            List<int> numbers = new List<int>()
            {
                11,
                10,
                14,
                16,
                18,
                30,
                22,
                24,
                26,
                28,
                20
            };



            DataAnalyser dataAnalyser = new DataAnalyser(numbers , new MinMaxSummary());


            dataAnalyser.Summarise();

            dataAnalyser.AddNumber(13);
            dataAnalyser.AddNumber(15);
            dataAnalyser.AddNumber(17);

            dataAnalyser.Strategy = new AverageSummary();

            dataAnalyser.Summarise();

        }
    }
}
