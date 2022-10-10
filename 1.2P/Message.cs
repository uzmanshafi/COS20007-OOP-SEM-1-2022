using System;

namespace HelloWorld
{
    public class Message
    {
        //private hides data from other classes and not within itself
        private string text; //private property
        public Message(string txt)
        {
            text = txt;
        }

        public void Print()
        {
            Console.WriteLine(text);
        }

    }
}
