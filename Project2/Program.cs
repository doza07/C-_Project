using System;
using System.Diagnostics;

namespace Project2
{
    internal class Program
    {
        public static int Sum(ref int a, ref int b)
        {
            return a + b;
        }
        public static void Main(string[] args)
        {
            int a = 2;
            int b = 6;
            Console.WriteLine(Sum(ref a, ref b));
        }
    }
}