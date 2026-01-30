using System;

class Que_22
{
    public static void main()
    {
        double?[] values = { 10.5, null, 20.0, 30.5, null };

        double sum = 0;
        int count = 0;

        foreach (double? v in values)
        {
            if (v.HasValue)
            {
                sum += v.Value;
                count++;
            }
        }

        double? average = null;

        if (count > 0)
        {
            average = Math.Round(sum / count, 2, MidpointRounding.AwayFromZero);
        }

        Console.WriteLine(average.HasValue ? average.ToString() : "null");
    }
}
