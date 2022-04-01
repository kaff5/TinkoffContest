using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong[] NAndK = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(i => ulong.Parse(i)).ToArray<ulong>();
            ulong N = NAndK[0];
            ulong K = NAndK[1];

            string num = N.ToString();

            List<ulong> res = new List<ulong>();

            int Raz = K.ToString().Length - num.Length;
            string n1 = num;

            for (int y = 0; y <= Raz; y++)
            {
                num = n1;
                for (int g = 0; g < y; g++)
                    num += "0";
                for (int i = 1; i <= 9; i++)
                {
                    for (int g = 0; g < num.Length; g++)
                    {
                        num = num.Remove(g, 1).Insert(g, i.ToString());
                    }
                    res.Add(ulong.Parse(num));
                }
            }


            ulong r = 0;
            foreach (ulong n in res)
            {
                if (n >= N && n <= K)
                {
                    r++;
                }

            }
            //Console.WriteLine();

            Console.WriteLine(r);
            Console.Read();





            /*bool SameDigits(ulong x)
            {
                ulong x1 = x / 10;
                return x1 == 0 || (x % 10 == x1 % 10 && SameDigits(x1));
            }*/

        }
        
    }
}