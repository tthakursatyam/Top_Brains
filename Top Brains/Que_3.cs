using System;
using System.Globalization;
using System.Text;

class Que_3
{
    public static void main()
    {
        string input = " llapppptop bag ";

        string trimmed = input.Trim().ToLower();

        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < trimmed.Length; i++)
        {
            if (i == 0 || trimmed[i] != trimmed[i - 1])
                sb.Append(trimmed[i]);
        }

        string cleaned = sb.ToString();

        TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
        string result = textInfo.ToTitleCase(cleaned);

        Console.WriteLine(result);
    }
}
