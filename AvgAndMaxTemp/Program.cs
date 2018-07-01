using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Paractical1
{
    /// <summary>  
    /// C# program that asks the user to enter a line of comma-separated temperature recordings. 
    /// then calculate the average temperature, the maximum temperature, and the number of temperatures between 0 - 10 (including 0 and 10).
    /// Author: Faryaz
    /// </summary>

    class MainClass
    {
        public static void Main(string[] args)
        {
            AvgAndMaxTemp();

        }
        static void AvgAndMaxTemp()
        {
            Write("Enter the line of comma separated temperatures: ");
            string line = ReadLine();
            string[] numsAsString = line.Split(',');
            List<double> group = numsAsString.Select(double.Parse).ToList();

            double sum = 0;
            foreach (double n in group)
            {
                sum = group.Sum();

            }
            double avg = 0;
            avg = sum / numsAsString.Length;

            double MaxTemp = group.Max();
            double count1 = 0;
            foreach (double n in group)
            {
                if (n >= 0 && n <= 10)
                {
                    count1++;
                }
            }

            WriteLine($"Average Temperature: {avg}");
            WriteLine($"Maximum Temperature: {MaxTemp}");
            WriteLine($"There are {count1} Temperatures between 0 - 10. ");
        }
    }
}