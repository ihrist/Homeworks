using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersInReversed
{
    class Program
    {
        static void Main(string[] args)
        {
            ReversedMethod();
        }
        static void ReversedMethod()
        {
            int n = int.Parse(Console.ReadLine());
            int left = n;
            int rev = 0;
            while (left > 0)
            {
                var r = left % 10;
                rev = rev * 10 + r;
                left = left / 10;  //left = Math.floor(left / 10); 
            }

            Console.WriteLine(rev);
        }
    }
}
