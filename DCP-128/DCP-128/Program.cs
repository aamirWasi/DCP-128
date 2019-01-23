using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DCP_128
{
    class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            for(int t = 1; t <= T; t++)
            {
                string line = Console.ReadLine();
                string[] space = line.Split(' ');
                double OA = double.Parse(space[0]);
                double BC = double.Parse(space[1]);
                double AB = 2 * OA;
                double AB1 = AB * AB;
                double BC1 = BC * BC;
                double AC = AB1 - BC1;
                double AC1 = (Math.Sqrt(AC));
                double sum = (AC1 * AC1);
                Console.WriteLine($"Case {t}: {sum}");
            }
        }
    }
}
