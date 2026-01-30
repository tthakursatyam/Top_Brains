using System;

class Que_9
{
    public static void main()
    {
        int feet = 5;

        double centimeters = feet * 30.48;
        centimeters = Math.Round(centimeters, 2, MidpointRounding.AwayFromZero);

        Console.WriteLine(centimeters);
    }
}
