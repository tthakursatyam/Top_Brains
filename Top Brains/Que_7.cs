using System;

class Que_7
{
    static void SwapRef(ref int a, ref int b)
    {
        a = a + b;
        b = a - b;
        a = a - b;
    }

    static void SwapOut(int x, int y, out int a, out int b)
    {
        x = x + y;
        y = x - y;
        x = x - y;

        a = x;
        b = y;
    }

    public static void main()
    {
        int a = 10;
        int b = 20;

        SwapRef(ref a, ref b);
        Console.WriteLine(a + " " + b);

        int x = 30;
        int y = 40;
        int r1, r2;

        SwapOut(x, y, out r1, out r2);
        Console.WriteLine(r1 + " " + r2);
    }
}
