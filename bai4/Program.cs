using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int intRes, intCnt = 1;
            while (intCnt <= 10)
            {
                intRes = intCnt * 5;
                Console.WriteLine("{0}", intRes);
                intCnt++;
            }
        }
    }
}
