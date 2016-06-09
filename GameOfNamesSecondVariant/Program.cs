using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfNamesSecondVariant
{
    class Program
    {
        static void Main(string[] args)
        {
           
                int input = int.Parse(Console.ReadLine());
            long MaxValue = long.MinValue;
                for (int i = 0; i < input; i++)
                {
                    string name = Console.ReadLine();
                    long number = long.Parse(Console.ReadLine());

                    for (int j = 0; j < name.Length; j++)
                    {
                        if (name[j]%2==0)
                        {
                            number += name[j];
                        }
                        else
                        {
                            number -= name[j];
                        }
                    }
                if (number>=MaxValue)
                {
                    Console.WriteLine("The winner is {0}- {1} points", name, number);
                }
            }
            }
        }
    }
    
