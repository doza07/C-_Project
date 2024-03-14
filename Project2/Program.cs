using System;

namespace Project2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            
            Program program = new Program();
            Console.WriteLine(program.Plus(2, 6));
        }

        public int Plus(int a, int b)
        {
            return a + b;
        }
    }
}