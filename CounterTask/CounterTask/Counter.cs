using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CounterTask
{
    public class Counter //Counter Class
    {
            //Q3
            private int _count;
            private string _name;

            public Counter(string name)
            {
                _name = name;
                _count = 0;
            }

            public void Increment() //increament method | Q4
            {
                ++_count;
            }

            public void Reset() //reset method | Q5
            {
                _count = 0;
            }

            public string Name // Name Properity | Q7
            {
                get { return _name; }

                set { _name = value; }
            }

            public int Tick // Tick Properity | Q8
            {
                get { return _count; }
                set { _count = value; }
            }

    }
}

