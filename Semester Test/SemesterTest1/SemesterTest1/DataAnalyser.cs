using System;
using System.Collections.Generic;

namespace SemesterTest1
{
    public class DataAnalyser
    {
        private List<int> _numbers;
        private SummaryStrategy _strategy;

        //4
        public SummaryStrategy Strategy
        {
            get
            {
                return _strategy;
            }
            set
            {
                _strategy = value;
            }
        }

        // Constructor that takes strategy and numbers 
        public DataAnalyser(SummaryStrategy strategy, List<int> numbers)
        {
            _strategy = strategy;
            _numbers = numbers;
        }

        //5. Modify the DataAnalyser constructors:

        public DataAnalyser(SummaryStrategy strategy) :
            this(strategy, new List<int>())
        {
        }

        public DataAnalyser() :
            this(new AverageSummary(), new List<int>())
        {
        }
        public DataAnalyser(List<int> numbers)
        {
            _numbers = numbers;
        }
        // 6 Modify DataAnalyser's Summarise method to use the currently stored strategy instead of relying on a string parameter
        public void Summarise()
        {
            _strategy.PrintSummary(_numbers);
        }

        public void AddNumbers(int num)
        {
            _numbers.Add(num);
        }
    }
}
