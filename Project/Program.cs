using System;
using System.Security.AccessControl;

namespace Project
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string sayHello = "Hello";
            Console.WriteLine(sayHello + "!" + " Enter your name:");

            string name = Console.ReadLine();
            Console.WriteLine(sayHello + " " + name);      
        }
    }
}