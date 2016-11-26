using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Number_in_Range__1._._._100_
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exists = false;
            while (!exists)
            {
                Console.WriteLine("Еnter a number in the range [1...100]:");
                var n = int.Parse(Console.ReadLine());
                if (n >= 1 && n <= 100){
                    Console.WriteLine("The number is: " + n);
                    exists = true;
                    break;
                }
                Console.WriteLine("Invalid number!");
            }
        }
    }
}
