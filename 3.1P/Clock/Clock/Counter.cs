using System;


namespace ClockTask
{
    //Counter Class 
    public class Counter
    {
        private int _count;
        private string _name;

        public Counter(string name)
        {
            _name = name;
            _count = 0;
        }
        // Increment method
        public void Increment()
        {
            _count++;
        }
        // Reset method
        public void Reset()
        {
            _count = 0;
        }
        // Name Property
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        //Ticks property
        public int Ticks
        {
            get { return _count; }
        }
    }
}
