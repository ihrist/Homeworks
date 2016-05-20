using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Program For calculating how many times an elevetor will make course for given numbers n - number of persons and
            //p-capacity of the elevator
            
            double n = double.Parse(Console.ReadLine());
            
            double p = double.Parse(Console.ReadLine());
            
            int courses = (int)Math.Ceiling((double)n / p);
            Console.WriteLine(courses);

        }
    }
}
