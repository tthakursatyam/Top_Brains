using System;
class Que_1
{
    static int SumDigits(int n)
    {
        int sum = 0;
        while (n > 0)
        {
            sum += n % 10;
            n /= 10;
        }
        return sum;
    }

    static bool IsPrime(int n)
    {
        if (n <= 1) return false;
        if (n == 2) return true;
        if (n % 2 == 0) return false;

        for (int i = 3; i * i <= n; i += 2)
        {
            if (n % i == 0)
                return false;
        }
        return true;
    }

    public static void main()
    {
        int m = 20;
        int n = 30;

        int count = 0;

        for (int i = m; i <= n; i++)
        {
            if (!IsPrime(i))
            {
                int s1 = SumDigits(i);
                int s2 = SumDigits(i * i);

                if (s2 == s1 * s1)
                    count++;
            }
        }

        Console.WriteLine(count);
    }
}
