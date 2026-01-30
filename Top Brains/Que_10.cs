using System;

class Que_10
{
    public static void main()
    {
        int heightCm = 170;

        string category;

        if (heightCm < 150)
            category = "Short";
        else if (heightCm < 180)
            category = "Average";
        else
            category = "Tall";

        Console.WriteLine(category);
    }
}
