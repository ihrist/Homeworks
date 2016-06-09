using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.SweetDesert
{
    class Program
    {
        static void Main(string[] args)
        {
            

            decimal IvanchoMoney = decimal.Parse(Console.ReadLine());
            decimal OnePortion = 6.0m;
            decimal GuestsNumber = decimal.Parse(Console.ReadLine());
            decimal NeededPortions = Math.Ceiling(GuestsNumber / OnePortion);
            

            decimal PricePerBanana = decimal.Parse(Console.ReadLine());
            decimal PricePerEgg = decimal.Parse(Console.ReadLine());
            decimal PricePerBerriesForKilo = decimal.Parse(Console.ReadLine());

            decimal TotalSumForBananas = NeededPortions * (2 * PricePerBanana);
            decimal TotalSumForEggs = NeededPortions * (4 * PricePerEgg);
            decimal TotalSumBerries = NeededPortions * ((decimal)0.2 * PricePerBerriesForKilo);

            decimal TotalSum = TotalSumForBananas + TotalSumBerries + TotalSumForEggs;

            if (TotalSum<=IvanchoMoney)
            {
                Console.WriteLine("Ivancho has enough money - it would cost {0:f2}lv.", TotalSum);
            }
            else
            {
                Console.WriteLine("Ivancho will have to withdraw money - he will need {0:f2}lv more.", TotalSum - IvanchoMoney);
            }
            
        }
    }
}
