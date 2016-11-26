using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond
{
    class Program
    {
        static void drawPart(int w, int h, string direction) {
            string[] lines = new string[h];
            int posL = 1;
            int posR = w - 2;
            for (int i = 0; i < h; i++) {
                string line = "";
                for (int j = 0; j < w; j++)
                {
                    line += (j == posL || j == posR) ? "*" : "-";
                }
                lines[i] = line;
                posL++;
                posR--;
            }
            if (direction.Equals("up"))
            {
                for (int i = 0; i < lines.Length; i++)
                {
                    Console.WriteLine(lines[i]);
                }
            }
            else {
                for (int i = lines.Length - 1; i >= 0; i--)
                {
                    Console.WriteLine(lines[i]);
                }
            }
        }
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            int height = (n%2 == 0) ? n/2-1 : n/2;
            drawPart(n, height, "down");
            for (int i = 0; i < n; i++)
            {
                Console.Write((i == 0 || i == n - 1) ? "*" : "-");
            }
            Console.WriteLine();
            drawPart(n, height, "up");
        }
    }
}
