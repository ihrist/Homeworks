using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoundingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] realNumbers = Console.ReadLine()
                .Split(' ').Select (double.Parse).ToArray();
            
            
        }

        static void RoundNumbersAwayFromZero(double[] realNumbers)
        {
            foreach (double number in realNumbers)
            {
                Console.WriteLine("{0} => {1}", number, Math.Round(number, MidpointRounding.AwayFromZero));
            }
        }

        
    }
}
