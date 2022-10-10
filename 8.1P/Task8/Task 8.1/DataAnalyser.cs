using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_8._1
{
    public class DataAnalyser
    {
        private List<int> _numbers;
        private AverageSummary _avgSummariser;
        private MinMaxSummary _minMaxSummariser;
        private SummaryStrategy _strategy;

        public DataAnalyser(): this(new List<int> () , new AverageSummary() )
        {
            
        }
        public DataAnalyser(List<int> numbers , SummaryStrategy strategy)
        {
            this._numbers = numbers;
            _strategy = strategy;

        }

        
        
        public void AddNumber(int num)
        {
            _numbers.Add(num);
        }
        
        public void Summarise()
        {
            _strategy.PrintSummary(_numbers);
        }

        public SummaryStrategy Strategy
        {
            get { return _strategy; }
            set { _strategy = value; }
        }
    }
}
