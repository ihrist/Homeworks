using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoldAndSumvotoroReshenie
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] firstArray = Console.ReadLine().Split().Select(char.Parse).ToArray();
            char[] secArray = Console.ReadLine().Split().Select(char.Parse).ToArray();

            int smallerArrrayLenght = Math.Min(firstArray.Length, secArray.Length);
            bool areEqual = false;

            for (int i = 0; i < smallerArrrayLenght; i++)
            {
                if (firstArray[i] == secArray[i])
                {
                    continue;
                }
                else
                {
                    if (firstArray[i] <= secArray[i])
                    {
                        Console.WriteLine(firstArray);
                        Console.WriteLine(secArray);
                    }
                    else
                    {
                        Console.WriteLine(secArray);
                        Console.WriteLine(firstArray);
                    }
                    areEqual = true;
                    break;
                }
            }
            if (!areEqual)
            {
                if (firstArray.Length<=secArray.Length)
                {
                    Console.WriteLine(firstArray);
                    Console.WriteLine(secArray);
                }
                else
                {
                    Console.WriteLine(secArray);
                    Console.WriteLine(firstArray);
                }
            }


        }
    }
}
