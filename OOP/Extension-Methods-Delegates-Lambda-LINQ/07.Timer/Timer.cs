namespace _07.Timer
{
    using System;
    using System.Threading;

    public class Timer
    {
        public delegate void TimerDelegate();

        public TimerDelegate SomeMethods { get; set; }

        private int timeInterval;

        public Timer(int seconds)
        {
            this.TimeInterval = seconds;
        }

        public int TimeInterval
        {
            get 
            { 
                return this.timeInterval; 
            }
            private set
            {
                if (value < 1)
                {
                    throw new ArgumentOutOfRangeException("Interval must be >= 1");
                }

                this.timeInterval = value;
            }
        }

        public void ExecuteMethods()
        {
            while (true)
            {
                this.SomeMethods();
                Thread.Sleep(this.timeInterval * 1000); // converts the milliseconds to seconds
            }
        }
    }
}