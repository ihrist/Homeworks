using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayPractice2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] eighthArray = new int[] { 1, 2, 3, 4 };
            for (int i = eighthArray.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(eighthArray[i] + " ");
            }
            int[] secondArray = new int[] { 1, 2, 3, 4 };
            foreach (var numbers in secondArray)
            {
                Console.WriteLine(numbers);
            }
            int[,] dvumerenMasiv;
            int[,,] triizmeren;
            int[,] dvuMasiv = new int[8, 8];
            int[,] matrica =
            {
                {1, 2, 3, 4},
                {5, 6, 7, 8}
            };
            //otpe4atvane na matricata
            for (int redove = 0; redove < matrica.GetLength(0); redove++)
            {
                for (int colon = 0; colon < matrica.GetLength(1); colon++)
                {
                    Console.Write(matrica[redove, colon] + " ");
                }
                Console.WriteLine();
            }
            //matrica ot konzolata
            int rows = int.Parse(Console.ReadLine());
            int cows = int.Parse(Console.ReadLine());
            int[,] matrixArray = new int[rows, cows];
            for (int row = 0; row < rows; row++)
            {
                for (int cow = 0; cow < cows; cow++)
                {
                    Console.WriteLine("matrix[{0},{1}] = ", row, cow);
                    matrixArray[row, cow] = int.Parse(Console.ReadLine());
                }
            }
            for (int row = 0; row < matrixArray.GetLength(0); row++)
            {
                for (int cow = 0; cow < matrixArray.GetLength(1); cow++)
                {
                    Console.Write(" " + "matrix[{0},{1}] = ", row, cow);

                }
                Console.WriteLine();
            }

        }
    }
}
