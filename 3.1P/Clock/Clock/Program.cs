using System;
using System.Timers;

namespace ClockTask
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Clock myClock = new Clock();
            int i = 0;
            while (i < 86400 )
            {
                myClock.Tick();
                Console.WriteLine(myClock.Time);
                i++;
                
            }
            Console.ReadLine();
        }
    }
}
