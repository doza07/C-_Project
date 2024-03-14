using System;
using System.Diagnostics;

namespace Project2
{
    internal class Program
    {
        public static int Sum(int a, int b)
        {
            return a + b;
        }
        public static void Main(string[] args)
        {
            Console.WriteLine(Sum(2, 6));
        }
    }
}