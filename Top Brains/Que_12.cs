using System;

class Que_12
{
    public static void main()
    {
        int totalSeconds = 125;

        int minutes = totalSeconds / 60;
        int seconds = totalSeconds % 60;

        string formatted = minutes + ":" + seconds.ToString("D2");

        Console.WriteLine(formatted);
    }
}
