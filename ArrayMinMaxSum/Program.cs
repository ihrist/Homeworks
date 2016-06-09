using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayMinMaxSum
{
    class Program
    {
        static void Main(string[] args)
        {
            //int n = int.Parse(Console.ReadLine());
            //int[] arr = new int[n];
            //for (int i = 0; i < n; i++)
            //{
            //    arr[i] = int.Parse(Console.ReadLine());
            //}
            //int sum = 0;
            //int min = arr[0];
            //int max = int.MinValue;
            //for (int i = 0; i < n; i++)
            //{
            //    sum = sum + arr[i];
            //    if (arr[i]<min)
            //    {
            //        min = arr[i];
            //        max = Math.Max(max, arr[i]);
            //    }
            //}
            //Console.WriteLine("Sum = " + arr.Sum());
            //Console.WriteLine("Min = " + arr.Min());
            //Console.WriteLine("Max = " + arr.Max());
            //Console.WriteLine("First = " + arr.First());
            //Console.WriteLine("Last = " + arr.Last());
            //Console.WriteLine("Average = " + (double)sum / n);


            //sukraten variant

            int z = int.Parse(Console.ReadLine());
            int[] arr = new int[z];
            for (int i = 0; i < z; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Sum =" + arr.Sum());
            Console.WriteLine("Min =" + arr.Min());
            Console.WriteLine("Max =" + arr.Max());
            Console.WriteLine("First =" + arr.First());
            Console.WriteLine("Last =" + arr.Last());
            Console.WriteLine("Average ={0:f2}", arr.Average());


           
        }
        
    }
}
