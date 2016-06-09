using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SheitanovArrayPracitce
{
    class Program
    {
        static void Main(string[] args)
        {

            //int size = int.Parse(Console.ReadLine());

            //int[] intArray = new int[size];
            //string[] StringArray = new string[size * 2];

            //for (int i = 0; i < intArray.Length; i++)
            //{
            //    intArray[i] = int.Parse(Console.ReadLine());
            //}

            ////Parsvane na imena ot konzolata s 4islo
            //int NamesNumbers = int.Parse(Console.ReadLine());
            //string[] MyClassMatesNamesInTheBar = new string[NamesNumbers];
            //for (int i = 0; i < NamesNumbers; i++)
            //{
            //    MyClassMatesNamesInTheBar[i] = Console.ReadLine();
            //}
            //foreach (var name in MyClassMatesNamesInTheBar)
            //{
            //    Console.WriteLine(name);
            //}

            ////How To split and reverse Array
            //string[] commandArgs = Console.ReadLine().Split
            //    (' ');
            //int[] numbers = new int[commandArgs.Length];
            //for (int i = 0; i < commandArgs.Length; i++)
            //{
            //    numbers[i] = int.Parse(commandArgs[i]);
            //}

            //Array.Reverse(numbers); // <!

            //for (int i = 0; i < commandArgs.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}
            Console.WriteLine(string.Join(" ", Console.ReadLine().Split().Select(int.Parse).Reverse()));

            Console.WriteLine("Write the names:");
            string[] names = Console.ReadLine().Split().ToArray();
            Console.WriteLine(string.Join(" ", names.Reverse()));



            //  Console.WriteLine(string.Join(", ", Console.ReadLine().Split()));



            //static void PrintArrya(int[] arr)
            //{
            //    for (int i = 0; i < arr.Length; i++)
            //    {

            //    }
            //}


        }
    }
}
