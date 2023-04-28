using System;
using System.Collections.Generic;

namespace SemesterTest1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Luan Nguyen 103812143");

            AverageSummary averagestrategy = new AverageSummary();
            MinMaxSummary minmaxstrategy = new MinMaxSummary();

            // a. Create a list and set strategy to minmax Strategy
            List<int> numbers = new List<int> { 1, 0, 3, 8, 1, 2, 1, 4, 3 };
            DataAnalyser analyser = new DataAnalyser(numbers);
            analyser.Strategy = minmaxstrategy;

            // b. Call Summary
            analyser.Summarise();

            // c. Add 3 numbers
            analyser.AddNumbers(26);
            analyser.AddNumbers(04);
            analyser.AddNumbers(23);

            // d. Set the summary strategy to the average strategy
            analyser.Strategy = averagestrategy;

            // e. Call Summary
            analyser.Summarise();
            Console.ReadLine();
        }
    }
}
