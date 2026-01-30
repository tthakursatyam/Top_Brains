using System;

class Que_8
{
    public static void main()
    {
        double radius = 5;

        double area = Math.PI * radius * radius;
        area = Math.Round(area, 2, MidpointRounding.AwayFromZero);

        Console.WriteLine(area);
    }
}
