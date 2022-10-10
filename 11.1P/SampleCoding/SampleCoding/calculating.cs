using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCoding
{
    public class calculating
    {
        private int a, b;

        public void add(int num1, int num2)
        {
            a = num1;
            b = num2;
            int total;
            total = a + b;
            Console.WriteLine("The Total of {0} and {1} is after adding is : {2}", a , b, total);
        }

        public void sub(int num1, int num2)
        {
            a = num1;
            b = num2;
            int total;
            total = a - b;
            Console.WriteLine("The Total of {0} and {1} is after subtracting is : {2}", a, b, total);
        }

        public void div(int num1, int num2)
        {
            a = num1;
            b = num2;
            int total;
            total = a / b;
            Console.WriteLine("The Total of {0} and {1} is after dividing is : {2}", a, b, total);
        }

        public void mul(int num1, int num2)
        {
            a = num1;
            b = num2;
            int total;
            total = a * b;
            Console.WriteLine("The Total of {0} and {1} is after multiplying is : {2}", a, b, total);
        }
    }
}
