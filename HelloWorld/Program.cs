using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            //Readline() to read input from consol
            string Username = Console.ReadLine();
            Console.WriteLine("Hello," + Username);
            
            Console.Read();
        
        }
    }
}
