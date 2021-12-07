using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    public class ConsoleApp1
    {
        
        public static void Main(String[] args)
        {
            var take = new ConsoleApp1();
            try
            {
                //taking user input
                Console.WriteLine("EMI Calculator for 2 wheeler");
                Console.WriteLine("Enter Principle Amount:");
                double p = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Rate of Interest:");
                double i = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter number of years:");
                double t = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Monthly Compounding:");
                double n = Convert.ToDouble(Console.ReadLine());

                var SpObject = new EmiCal();
                double emi = SpObject.Emi_calculator(p, i, t, n);
                //print output
                Console.WriteLine("Monthly EMI is:" + emi);
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message); 
            }
        }

    }
}