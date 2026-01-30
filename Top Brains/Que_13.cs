using System;
class Que_13
{
    public static void main()
    {
        int[] nums = { 5, -2, 10, 3, 0, 8, 4 };

        int sum = 0;

        foreach (int n in nums)
        {
            if (n == 0)
                break;

            if (n < 0)
                continue;

            sum += n;
        }

        Console.WriteLine(sum);
    }
}
