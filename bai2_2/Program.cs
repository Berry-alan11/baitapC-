using System;

class Maths
{
    public void DoOverLoad()
    {
        int intX = 3;
        double dblY = 4.2;
        Console.WriteLine("Square of int value is : " + Square(intX) + "\n" + "Square of double value is : " + Square(dblY));
    }

    public int Square(int intY)
    {
        return intY * intY;
    }

    public double Square(double dblY)
    {
        return dblY * dblY;
    }
}

public class OverLoad
{
    public static void Main()
    {
        Maths objMaths = new Maths();
        objMaths.DoOverLoad();
    }
}