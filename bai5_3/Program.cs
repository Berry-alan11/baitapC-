using System;
using System.IO;

class DirTest
{
    public static void Main()
    {
        string strans;
        Console.WriteLine(@"creating directory c:\Testdir.....");
        Directory.CreateDirectory(@"C:\Testdir");
        Console.WriteLine("Directory created.......");
        Console.WriteLine(@"Delete directory c:\Testdir (y/n)? :");
        strans = Console.ReadLine();
        if (strans == "y")
        {
            Directory.Delete(@"C:\Testdir");
            Console.WriteLine(@"Directory c:\Testdir deleted");
        }
    }
}
