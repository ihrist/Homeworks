using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ArrayLenght
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = array[i] * 5;
                Console.Write(array[i] + " ");
            }


            int[] SecArray = { 1, 2, 3 };
            int[] thirdArray = { 1, 2, 3, 4 };
            for (int i = 0; i < 1; i++)
            {
                if (SecArray.Length == thirdArray.Length)
                {
                    Console.WriteLine("Ravni sa");

                }
                else
                {
                    Console.WriteLine("Ne sa ravni");
                }
            }





            string s = Console.ReadLine();
            byte[] ASCIIValues = Encoding.ASCII.GetBytes(s);
            int sum = 0;
            foreach (byte b in ASCIIValues)
            {

                Console.WriteLine(b);
            }
        }
    }
}
