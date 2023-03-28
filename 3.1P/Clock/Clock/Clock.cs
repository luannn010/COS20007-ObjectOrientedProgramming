using System;
using System.Timers;
using System.Text;


namespace ClockTask
{
    public class Clock
    {

        private Counter seconds;
        private Counter minutes;
        private Counter hours;
        // Create Clock Method
        public Clock()
        {
            seconds = new Counter("seconds");
            minutes = new Counter("minutes");
            hours = new Counter("hours");
        }
        // Create Tick method 
        public void Tick()
        {
            // Reset seconds when reach 60
            seconds.Increment();
            if (seconds.Ticks == 60)
            {
                seconds.Reset();
                minutes.Increment();
            }
            // Reset minutes when reach 60
            if (minutes.Ticks == 60)
            {
                minutes.Reset();
                hours.Increment();
            }
            // Reset hours when reach 24
            if (hours.Ticks == 24)
            {
                Reset();
            }
        }
        // Create Reset method
        public void Reset()
        {
            //Reset when reach the limit
            seconds.Reset();
            minutes.Reset();
            hours.Reset();
        }
        // Format time to hh:mm:ss
        public string Time
        {
            get
            {
                return hours.Ticks.ToString("D2") + ":" + minutes.Ticks.ToString("D2") + ":" + seconds.Ticks.ToString("D2");
            }
        }
    }
}
