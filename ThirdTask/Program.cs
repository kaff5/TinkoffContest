using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdTask
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] NAndT = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(i => int.Parse(i)).ToArray<int>();
            int N = NAndT[0];
            int T = NAndT[1];
            int[] floors = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(i => int.Parse(i)).ToArray<int>();
            int man = int.Parse(Console.ReadLine());
            long k = 0;

            if (T >= floors[man - 1] - floors[0])
            {
                k = floors[N - 1] - floors[0];
            }
            else
            {
                if (floors[N - 1] - floors[man - 1] <= T || floors[man - 1] - floors[0] <= T)
                {
                    k = floors[N - 1] - floors[0];
                }
                else
                {
                    if (floors[N - 1] - floors[man - 1] >= floors[man - 1] - floors[0])
                    {
                        k = floors[man - 1] - floors[0] + floors[N - 1] - floors[0];
                    }
                    else
                    {
                        k = floors[N - 1] - floors[man - 1] + floors[N - 1] - floors[0];
                    }
                }
            }
            Console.WriteLine(k);
        }
    }
}
