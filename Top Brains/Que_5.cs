using System;
using System.IO;

class Que_5
{
    public static void main()
    {
        string inputPath = "log.txt";
        string outputPath = "error.txt";

        if (!File.Exists(inputPath))
            return;

        string[] lines = File.ReadAllLines(inputPath);

        using (StreamWriter writer = new StreamWriter(outputPath))
        {
            foreach (string line in lines)
            {
                if (line.Contains("ERROR"))
                {
                    writer.WriteLine(line);
                }
            }
        }

        Console.WriteLine("Done");
    }
}
