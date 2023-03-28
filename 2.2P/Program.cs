using System;
namespace CounterTask;

public class Program
{
    // Create the PrinCounter Static method
    private static void PrintCounter(Counter[] counters)
    {
       
        foreach(Counter c in counters)
        {
            Console.WriteLine("{0} is {1}", c.Name, c.Ticks);
        }
    }
    public static void Main(string[] args)
    {
        Counter[] myCounters = new Counter[3];
        int i;
        myCounters[0] = new Counter("Counter 1");
        myCounters[1] = new Counter("Counter 2");
        myCounters[2] = myCounters[0];
        //Counter 1 count to 10
        for (i = 0; i <= 9; i++)
        {
            myCounters[0].Increment();
            
        }
        // Counter 2 count to 15
        for (i= 0; i <= 14; i++)
        {
            myCounters[1].Increment();
            

        }
        PrintCounter(myCounters);
        //Reset Counter 1
        myCounters[2].Reset();
        PrintCounter(myCounters);
        Console.ReadLine();
    }

}
