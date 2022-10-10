using System;

namespace Clock
{
    public class Clock
    {
        private Counter hour;
        private Counter minute;
        private Counter second;

        public Clock()
        {
            hour = new Counter("Hour");
            minute = new Counter("Minute");
            second = new Counter("Second");
        }

        public void Tick()
        {
            if (second.Tick == 59)
            {
                second.Reset();
                if (minute.Tick == 59)
                {
                    minute.Reset();
                    if (hour.Tick == 23)
                    {
                        hour.Reset();
                        minute.Reset();
                        second.Reset();
                    }
                    else
                    {
                        hour.Increment();
                    }
                }
                else
                {
                    minute.Increment();
                }
            }
            else
            {
                second.Increment();
            }
        }

        public void Reset()
        {
            hour.Reset();
            minute.Reset();
            second.Reset();
        }

        public string time
        {
            get 
            {
                return $"{hour.Tick:00}:{minute.Tick:00}:{second.Tick:00}";
            }
        }
    }
}
