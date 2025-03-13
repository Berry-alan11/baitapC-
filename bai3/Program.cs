using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int intNum = 10;
            funcSqr (intNum);
            Console.ReadLine();
        }
        static void funcSqr(int intNum)
        {
            int intSqr = intNum * intNum;
            Console.WriteLine("Square of the number 10 is {0}", intSqr);
        }
    }
}
