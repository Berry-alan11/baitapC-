using System;

class Ascend
{
    public static void Main()
    {
        int[] intArray1 = { 12, 34, 26, 108, 10 };
        int[] intArray2 = { 0, 0, 0, 0, 0 };
        Console.WriteLine("The contents of array are as follows : ");
        ShowArr(intArray1);
        Array.Copy(intArray1, intArray2, 5);
        Array.Sort(intArray2);
        Console.WriteLine("The contents of arrays after copying and arranging are as follows :");
        Console.WriteLine("Array 1 :");
        ShowArr(intArray1);
        Console.WriteLine("Array 2 :");
        ShowArr(intArray2);
    }

    public static void ShowArr(Array iArray)
    {
        foreach (int cnt in iArray)
        {
            Console.WriteLine(cnt);
        }
    }
}