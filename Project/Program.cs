using System;
using System.Globalization;

namespace Project
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string x = "1.9";

            NumberFormatInfo numberFormatInfo = new NumberFormatInfo()
            {
                NumberDecimalSeparator = "."
            };
            Console.WriteLine(Convert.ToDouble(x, numberFormatInfo));
            
        }
    }
}