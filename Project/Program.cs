using System;
using System.Globalization;

namespace Project
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string str = "5,3";
            double num = 5;
            
            Console.WriteLine(str + num);
            NumberFormatInfo numberFormatInfo = new NumberFormatInfo()
            {
                NumberDecimalSeparator = ","
            };
            
            double numFromStr = double.Parse(str, numberFormatInfo);
            Console.WriteLine(num + numFromStr);
        }
    }
}