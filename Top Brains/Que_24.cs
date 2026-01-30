using System;
using System.Collections.Generic;
using System.Text.Json;

record Student(string Name, int Score);

class Que_24
{
    public static void main()
    {
        string[] items =
        {
            "John:85",
            "Alice:92",
            "Mark:78",
            "Bob:92"
        };

        int minScore = 80;

        List<Student> students = new List<Student>();

        foreach (var item in items)
        {
            string[] parts = item.Split(':');
            students.Add(new Student(parts[0], int.Parse(parts[1])));
        }

        students = students
            .FindAll(s => s.Score >= minScore);

        students.Sort((a, b) =>
        {
            int scoreCompare = b.Score.CompareTo(a.Score);
            if (scoreCompare != 0)
                return scoreCompare;
            return a.Name.CompareTo(b.Name);
        });

        string json = JsonSerializer.Serialize(students);

        Console.WriteLine(json);
    }
}
