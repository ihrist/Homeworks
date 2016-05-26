using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfNames
{
    class Program
    {
        static void Main(string[] args)
        {
            int p = int.Parse(Console.ReadLine());
            int[] fourthArray = new int[p];
            
            string PlayerName = string.Empty;
            long MaxPoints = long.MinValue;
            string winner = string.Empty;
            

            for (int i = 0; i < p; i++)
            {
                PlayerName = Console.ReadLine();
                int InitialScores = int.Parse(Console.ReadLine());
                int sum = InitialScores;
                for (int j = 0; j < PlayerName.Length; j++)
                {
                    if (PlayerName[j] % 2 ==0)
                    {
                        sum += PlayerName[j];
                    }
                    else
                    {
                        sum -= PlayerName[j];
                    }
                }

                if (sum >= MaxPoints)
                {
                    Console.WriteLine("The winner is {0}- {1} points", PlayerName, sum);
                }
                
            }


        }
    }
}
