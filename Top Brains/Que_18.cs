using System;

class Que_18
{
    public static void main()
    {
        object[] values = { 10, "Hello", 20, true, null, 30, 5.5, false, 40 };

        int sum = 0;

        foreach (object val in values)
        {
            if (val is int x)
            {
                sum += x;
            }
        }

        Console.WriteLine("Sum of integers: " + sum);
    }
}
