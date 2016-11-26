using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House
{
    class Program
    {
        static void drawRoof(int w, int h) {
            string[] lines = new string[h];
            int paddingL = -1;
            int paddingR = w;
            for (var i = 0; i < h; i++) {
                string line = "";

                for (var j = 0; j < w; j++)
                {
                    line += (j > paddingL && j < paddingR) ? "*" : "-";
                }
                lines[i] = line;
                paddingL++;
                paddingR--;
            }
            for (var i = lines.Length - 1; i >= 0; i--) {
                Console.WriteLine(lines[i]);
            }
        }

        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            int height = (n%2 == 0) ? n/2 : n/2+1;
            drawRoof(n, height);

            for (int i = 0; i < n - height; i++) {
                for (int j = 0; j < n; j++) {
                    Console.Write((j == 0 || j == n - 1) ? "|" : "*");
                }
                Console.WriteLine();
            }
        }
    }
}
