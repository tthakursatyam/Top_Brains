using System;

class Que_11
{
    public static void main()
    {
        int a = 25;
        int b = 40;
        int c = 15;

        int largest;

        if (a >= b && a >= c)
            largest = a;
        else if (b >= a && b >= c)
            largest = b;
        else
            largest = c;

        Console.WriteLine(largest);
    }
}
