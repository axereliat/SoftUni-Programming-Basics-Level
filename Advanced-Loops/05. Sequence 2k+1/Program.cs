using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Sequence_2k_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            int num = 1, num_old = 1;

            for (int i = 0; i <= n; i++)
            {
                num_old = num;
                Console.WriteLine(num);
                num = 2 * num_old + 1;
                if (num > n) {
                    break;
                }
            }
        }
    }
}
