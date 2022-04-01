using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTask
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ints = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(i => int.Parse(i)).ToArray<int>();

            int A = ints[0];
            int B = ints[1];
            int C = ints[2];
            int D = ints[3];
            int sum = A;
            if (D - B > 0)
            {
                for (int i = 0; i < D - B; i++)
                {
                    sum += C;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
