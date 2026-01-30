using System;

class Que_15
{
    public static void main()
    {
        string[] tokens = { "10", "20", "abc", "2147483647", "2147483648", "-5", "xyz" };

        int sum = 0;

        foreach (string s in tokens)
        {
            int value;
            if (int.TryParse(s, out value))
            {
                sum += value;
            }
        }

        Console.WriteLine(sum);
    }
}
