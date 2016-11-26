using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Christmas_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var interval_cnt = n - 1;


            for (var i = 0; i < n+1; i++) {
                Console.Write(" ");
            }
            Console.Write("|");
            Console.WriteLine();
            for (var i = 0; i < n; i++)
            {
                for (var j = 0; j < n; j++) {
                    if (j < interval_cnt)
                    {
                        Console.Write(" ");
                    }
                    else {
                        Console.Write("*");
                    }
                }
                Console.Write(" | ");
                for (var k = 0; k < i+1; k++) {
                    Console.Write("*");
                }
                Console.WriteLine();
                interval_cnt--;
            }
        }
    }
}
