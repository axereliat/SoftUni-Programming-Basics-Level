using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Greatest_Common_Divisor__CGD_
{
    class Program
    {
        static void Main()
        {
            // input
            Console.Write("\nPlease enter the first number: ");
            int biggerNumber = int.Parse(Console.ReadLine());
            Console.Write("\nPlease enter the second number: ");
            int smallerNumber = int.Parse(Console.ReadLine());

            // we need to first determine which one of the numbers is the bigger one
            // and if the initially decalred bigger number is actually the smaller one -
            // we swap their values
            if (biggerNumber < smallerNumber)
            {
                biggerNumber = biggerNumber + smallerNumber;
                smallerNumber = biggerNumber - smallerNumber;
                biggerNumber = biggerNumber - smallerNumber;
            }

            // logic: The Euclidean algorithm is based on the principle that 
            // the greatest common divisor of two numbers does not change if the larger number
            // is replaced by its difference with the smaller number. 
            int divisor = (biggerNumber % smallerNumber);

            while (divisor != 0)
            {
                biggerNumber = smallerNumber;
                smallerNumber = divisor;
                divisor = biggerNumber % smallerNumber;
            }

            Console.WriteLine("\nGCD = {0}\n", smallerNumber);
        }
    }
}
