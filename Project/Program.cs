using System;
using System.Globalization;

namespace Project
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string str = null;
            Console.WriteLine(str ?? "No Data");
        }
    }
}