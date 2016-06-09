using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumArrays
{
    class Program
    {
        static void Main(string[] args)
        {//srravniavane duljinite na 2 masiva
            int[] firstArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] secArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int largerLenght = Math.Max(firstArray.Length, secArray.Length);
            for (int i = 0; i < largerLenght; i++)
            {
                int firstValue = firstArray[i % firstArray.Length];
                int secValue = secArray[i % secArray.Length];
                Console.WriteLine("{0}", firstValue + secValue);
            }
        }
    }
}
