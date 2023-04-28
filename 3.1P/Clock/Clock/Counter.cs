using System;


namespace ClockTask
{
  

   
    public class Counter
    {
        // Fields
        private int _count;
        private string _name;
        // Constructor
        public Counter(string name)
        {
            _name = name;
            _count = 0;
        }
        // Functions
        public void Increment()
        {
            _count++;
        }

        public void Reset()
        {
            _count = 0;
        }
       // Properties
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
        
        public int Ticks
        {
            get
            {
                return _count;
            }
        }
    }
}
