using System;

class Que_16
{
    static int GCD(int a, int b)
    {
        if (b == 0)
            return a;
        return GCD(b, a % b);
    }

    public static void main()
    {
        int a = 48;
        int b = 18;

        int result = GCD(a, b);

        Console.WriteLine(result);
    }
}
