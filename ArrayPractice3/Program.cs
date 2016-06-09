using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayPractice3
{
    class Program
    {
        static void Main(string[] args)
        {
            int row = int.Parse(Console.ReadLine());
            int pow = int.Parse(Console.ReadLine());
            int[,] Matrix = new int[row, pow];
            for (int i = 0; i < row; i++)
            {
                for (int col = 0; col < pow; col++)
                {
                    Console.WriteLine("matrix {0}{1}", row, pow);
                    Matrix[row, col] = int.Parse(Console.ReadLine());
                }
            }
            for (int rows = 0; row < Matrix.GetLength(0); row++)
            {
                for (int col = 0; col < Matrix.GetLength(1); col++)
                {
                    Console.Write(" " + Matrix[row, col]);
                }
                Console.WriteLine();
            }


            //

        }
    }
}
