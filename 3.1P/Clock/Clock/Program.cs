using System;
using System.Timers;

namespace ClockTask
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Clock myClock = new Clock();
            while (true)
            {
                myClock.Tick();
                Console.WriteLine(myClock.Time);
            }
        }
    }
}
