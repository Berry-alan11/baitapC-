using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String strDow;
            Console.WriteLine("Enter a number between 1 and 7: ");
            strDow = Console.ReadLine();
            switch(strDow)
            {
                case "1":
                    Console.WriteLine("First day of week is Sunday");
                    break;
                case "2":
                    Console.WriteLine("Second day of week is Monday");
                    break;
                case "3":
                    Console.WriteLine("Third day of week is Tuesday");
                    break;
                case "4":
                    Console.WriteLine("Fourth day of week is Wednesday");
                    break;
                case "5":
                    Console.WriteLine("Fifth day of week is Thursday");
                    break;
                case "6":
                    Console.WriteLine("Sixth day of week is Friday");
                    break;
                case "7":
                    Console.WriteLine("Seventh day of week is Saturday");
                    break;
                default:
                    Console.WriteLine("Enter a numebr between 1 and 7");
                    break;
            }
        }
    }
}
