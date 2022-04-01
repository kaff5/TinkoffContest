using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondTask
{
    class Program
    {
        static void Main(string[] args)
        {
            long A = Int32.Parse(Console.ReadLine());

            long B = 1;
            long i = 0;

            while (B < A)
            {
                B *= 2;
                i++;
            }

            Console.WriteLine(i);
        }
    }
}
