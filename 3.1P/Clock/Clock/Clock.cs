using System;
using System.Timers;
using System.Text;


namespace ClockTask
{
    public class Clock
    {
        //Fields
        private Counter seconds;
        private Counter minutes;
        private Counter hours;
        // Constructor
        public Clock()
        {
            seconds = new Counter("seconds");
            minutes = new Counter("minutes");
            hours = new Counter("hours");
        }
        // Functions
        public void Tick()
        {
            
            seconds.Increment();
            if (seconds.Ticks == 60)
            {
                seconds.Reset();
                minutes.Increment();
            }
            
            if (minutes.Ticks == 60)
            {
                minutes.Reset();
                hours.Increment();
            }
            
            if (hours.Ticks == 24)
            {
                Reset();
            }
        }

        public void Reset()
        {
            
            seconds.Reset();
            minutes.Reset();
            hours.Reset();
        }
       // Property
        public string Time
        {
            get
            {
                return hours.Ticks.ToString("D2") + ":" + minutes.Ticks.ToString("D2") + ":" + seconds.Ticks.ToString("D2");
            }
        }
    }
}
