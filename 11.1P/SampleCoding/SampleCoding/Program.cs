using System;

namespace SampleCoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            calculating calculating = new calculating();

            Console.WriteLine("Welcome to the MATHS Academy -->\n");
            Console.WriteLine("Enter Your First Number : ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Enter Your Second Number : ");
            int n2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Do you want to add (+) , sub (-), divide /, multiply (*) or exit");
            string[] choice = {"", "+" , "-", "/", "*", "exit"};
            choice[0] = Console.ReadLine();
            while (choice[0] != "exit")
            {
                if (choice[0] == "+")
                {
                    calculating.add(n1,n2);
                }else if (choice[0] == "-")
                {
                    calculating.sub(n1, n2);
                }
                else if (choice[0] == "/")
                {
                    calculating.div(n1, n2);
                }
                else if (choice[0] == "*")
                {
                    calculating.mul(n1, n2);
                }
                Console.ReadLine();
            }
            Console.WriteLine("Disconnected Player {0} from the game...");
        }
    }
}
