using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourTask
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] NAndK = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(i => long.Parse(i)).ToArray<long>();
            int N = (int)NAndK[0];
            long K = NAndK[1];
            long[] numbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(i => long.Parse(i)).ToArray<long>();


            Array.Sort(numbers);

            long sumFirst = 0;
            long sumSecond = 0;


            sumFirst = numbers.Sum();

            long max = 0;
            long indMax = 0;


            for (long l = 0; l < K; l++)
            {
                List<long> modNums = new List<long>();
                for (long g = 0; g < numbers.Length; g++)
                {

                    string modNum = numbers[g].ToString();
                    for (long o = 0; o < modNum.Length; o++)
                    {
                        if (modNum[(int)o] != '9')
                        {
                            modNum = modNum.Remove((int)o, 1).Insert((int)o, "9");
                            o = modNum.Length;
                        }
                    }
                    long modNum1 = long.Parse(modNum);
                    if (max <= modNum1 - numbers[g])
                    {
                        max = modNum1 - numbers[g];
                        indMax = g;
                    }
                    modNums.Add(modNum1);

                }
                numbers[indMax] = modNums[(int)indMax];
                max = 0;
                indMax = 0;
            }

            sumSecond = numbers.Sum();

            Console.WriteLine(sumSecond - sumFirst);
        }
    }
}
