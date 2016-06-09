using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] myArray = new int[6];
            int[] secArray = { 1, 2, 3, 4, 5, 6 };
            string[] stringArray = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            //dostup do el. na masiv
            int[] newArray = new int[6];
            newArray[1] = 5;
            newArray[2] = 4;
            newArray[3] = 3;
            newArray[4] = 2;
            newArray[5] = 1;
            for (int i = 0; i < newArray.Length; i++)
            {
                newArray[i] = i;
            }
            Console.WriteLine(secArray[4]);
            //masiv v obraten red
            int[] thirdArray = { 1, 2, 3, 4, 5, 6 };
            int lenght = thirdArray.Length;
            int[] reversed = new int[lenght];
            for (int i = 0; i < lenght; i++)
            {
                reversed[lenght - i - 1] = thirdArray[i];
            }
            for (int index = 0;  index < lenght; index++)
            {
                Console.WriteLine(reversed[index] + " ");
            }
            //chetene na masiv ot konzolata
            Console.Write("Write the number(lenght) of the Array:");
            int n = int.Parse(Console.ReadLine());
            int[] fourthArray = new int[n];
            for (int i = 0; i < n; i++)
            {
                fourthArray[i] = int.Parse(Console.ReadLine());
            }
            //iteracia na masiv na konzolata-string
            Console.WriteLine("Gradovete v bulgaria po nizhodiasht red");
            string[] bgGradove = { "Sofia", "Plovdiv", "Varna", "Rusi", "Burgas" };
            for (int i = 0; i < bgGradove.Length; i++)
            {
                Console.WriteLine("Element[{0}] = {1}", i, bgGradove[i]);
            }
            //iteracial po stoinostite na masivite
            int[] sixthArray = new int[] { 1, 2, 3, 4, 5, 6 };
            for (int i = 0; i < sixthArray.Length; i++)
            {
                sixthArray[i] = 2 * sixthArray[i];
                Console.WriteLine(sixthArray[i] + " ");
            }
            //2-ri primer
            int[] seventhArray = new int[] { 2, 4 };
            for (int i = 0; i < seventhArray.Length; i += 2)
            {
                seventhArray[i] = seventhArray[i] * seventhArray[i];
                Console.WriteLine(seventhArray[i] + " ");
            }
            //reversed array
            
            
        }
    }
}
