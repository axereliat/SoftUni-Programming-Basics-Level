using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sunglasses
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var half = n / 2;

            if (n % 2 != 0)
            {
                half++;
            }
            for (var i = 0; i < n; i++) {
                for (var j = 0; j < 2*n; j++) {
                    if (i != 0 && i != n - 1)
                    {
                        if (j == 0 || j == 2*n - 1)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write("/");
                        }
                    }
                    else {
                        Console.Write("*");
                    }
                }
                for (var k = 0; k < n; k++) {
                    if (i == half - 1)
                    {
                        Console.Write("|");
                    }
                    else {
                        Console.Write(" ");
                    }
                }
                for (var l = 0; l < 2*n; l++) {
                    if (i != 0 && i != n - 1)
                    {
                        if (l == 0 || l == 2 * n - 1)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write("/");
                        }
                    }
                    else
                    {
                        Console.Write("*");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
