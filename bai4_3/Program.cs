using System;

class ArrayTest
{
    public static void Main()
    {
        int[] intArray1 = { 2, 4, 6, 8, 10 };
        int[] intArray2 = new int[5];
        Console.WriteLine("First Array");
        ShowArr(intArray1);
        Console.WriteLine("Second Array");
        ShowArr(intArray2);
        Array.Copy(intArray1, intArray2, 5);
        Array.Reverse(intArray2);
        Console.WriteLine("Second array after copying and reversing first array");
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