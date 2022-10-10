using System;


namespace HelloWorld
{
    class Program
    {   
        public static void Main(string[] args)
        {
            Message myMessage;
            string Name; //created to program logic

            myMessage = new Message("Hello World! - from Message Object");
            myMessage.Print();

            Message[] messages = new Message[4];
            messages[0] = new Message("Welcome Back!");
            messages[1] = new Message("What a lovely name");
            messages[2] = new Message("Great name");
            messages[3] = new Message("That is a silly name");
            
            string name;
            Console.WriteLine("Enter Name : ");
            name = Console.ReadLine().ToLower();

            if (name == "chris")
            {
                messages[0].Print();
            }
            else if (name == "fred")
            {
                messages[1].Print();
            }

            Console.ReadLine();
        }
    }
}
