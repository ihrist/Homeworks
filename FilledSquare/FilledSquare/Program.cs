using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilledSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program to draw at the console a filled square of size n like in the examples below.
            //--------
            //-\/\/\/-
            //-\/\/\/-
            //--------

            int n = int.Parse(Console.ReadLine());
            PrintHeaderRow(n);
            
            for (int i = 0; i < n - 2; i++)
            {
                PrintHeaderRow(n);
                PrintMiddleRow(n);
            }
        }
        static void PrintHeaderRow(int n)
        {
            Console.WriteLine(new string('-', 2 * n));
        }
        static void PrintMiddleRow(int n)
        {
            Console.Write('-');
            for (int i = 1; i < n; i++)
            {
                Console.Write("\\/");
                
            }
            Console.WriteLine("-");

        }
    }
}
