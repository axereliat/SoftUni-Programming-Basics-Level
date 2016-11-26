using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rhombus
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var interval_cnt = n - 1;

            for (var i = 0; i < n; i++)
            {
                for (var j = 0; j < n; j++)
                {
                    if (j < interval_cnt)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write("* ");
                    }
                }
                interval_cnt--;
                Console.WriteLine();
            }
            interval_cnt = 1;
            for (var i = 0; i < n; i++)
            {
                for (var j = 0; j < n; j++)
                {
                    if (j < interval_cnt)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write("* ");
                    }
                }
                interval_cnt++;
                Console.WriteLine();
            }
        }
    }
}
