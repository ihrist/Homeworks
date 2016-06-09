using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //RotateAndSum
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rotations = int.Parse(Console.ReadLine());
            //deklarirame masiva
            int[] sumOfRotations = new int[numbers.Length];
            //deklarirame 4isloto
            for (int currentrotations = 0; currentrotations < rotations; currentrotations++)
            {
                int LastElement = numbers[numbers.Length - 1];
                for (int currentElement = numbers.Length-1; currentElement > 0; currentElement--)
                {
                    numbers[currentElement] = numbers[currentElement - 1];
                }
                numbers[0] = LastElement;
                for (int currentElement = 0; currentElement < numbers.Length; currentElement++)
                {
                    sumOfRotations[currentElement] += numbers[currentElement];
                }
                
            }
            Console.WriteLine(string.Join(" ", sumOfRotations));
           

        }
    }
}
