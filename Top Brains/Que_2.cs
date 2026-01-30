using System;
using System.Text;

class Que_2
{
    static bool IsVowel(char c)
    {
        c = char.ToLower(c);
        return c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u';
    }

    public static void main()
    {
        string first = "Mahirl";
        string second = "Sam";

        string secondLower = second.ToLower();
        StringBuilder filtered = new StringBuilder();

        foreach (char c in first)
        {
            char lower = char.ToLower(c);

            if (!IsVowel(c) && secondLower.Contains(lower))
                continue;

            filtered.Append(c);
        }

        StringBuilder result = new StringBuilder();

        for (int i = 0; i < filtered.Length; i++)
        {
            if (i == 0 || filtered[i] != filtered[i - 1])
                result.Append(filtered[i]);
        }

        Console.WriteLine(result.ToString());
    }
}
