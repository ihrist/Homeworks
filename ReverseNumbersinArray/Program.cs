using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseNumbersinArray
{
    class Program
    {
        static void Main(string[] args)
        {
            var items = Console.ReadLine().Split(' ').ToArray();
            var result = new string[items.Length];
            for (int i = 0; i < items.Length; i++)
            {
                result[items.Length - i - 1] = items[i];
            }
            var reverseditems = items.Reverse().ToArray();

            Console.WriteLine(string.Join(" ", reverseditems));
        }
    }
}
