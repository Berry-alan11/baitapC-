using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int intNum = 1, intCnt, intNumHalf = 0, intI = 0;
            bool IsPrime = true;
            Console.WriteLine("The Firstt 10 prime Number are");
            while (intI < 10)
            {
                intNum += 1;
                intNumHalf = intNum / 2;
                intCnt = 2; // Initialize intCnt before using it
                while (intCnt <= intNumHalf)
                {
                    if (intNum % intCnt == 0)
                    {
                        IsPrime = false;
                        break;
                    }
                    intCnt += 1;
                }
                if (IsPrime == true)
                {
                    intI++;
                    Console.WriteLine("{0}", intNum);
                }
                else
                    IsPrime = true;
            }
            Console.ReadLine();
        }
    }
}
