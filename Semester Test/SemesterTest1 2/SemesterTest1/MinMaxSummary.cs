using System;
namespace SemesterTest1
{
	public class MinMaxSummary : SummaryStrategy
	{
        // Print Biggest and Smallest
        public override void PrintSummary(List<int> numbers)
        {
            Console.WriteLine($"The Biggest number in your Student ID is: {Max(numbers)}\n" +
                              $"The Smallest number in your Student ID is: {Min(numbers)}");
        }
        // Method
        public int Max(List<int> numbers)
        {
            int biggest = numbers[0];
            foreach (int i in numbers)
            {
                if (i >= biggest)
                    biggest = i;

            }
            return biggest;

        }
        public int Min(List<int> numbers)
        {
            int smallest = numbers[0];
            foreach (int i in numbers)
            {
                if (i <= smallest)
                    smallest = i;
            }
            return smallest;
        }

    }
}

