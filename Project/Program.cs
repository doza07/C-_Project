using System;
using System.Globalization;

namespace Project
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string str = "5egfw";
            int a;
            
            bool result = int.TryParse(str, out a);

            if (result)
            {
                Console.WriteLine("Done parse");
            }
            else
            {
                Console.WriteLine("Error parse!");
            }
        }
    }
}