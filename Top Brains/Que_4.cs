using System;
using System.Collections.Generic;

class Student1 : IComparable<Student1>
{
    public string Name { get; set; }
    public int Age { get; set; }
    public int Marks { get; set; }

    public int CompareTo(Student1 other)
    {
        int marksCompare = other.Marks.CompareTo(this.Marks); 
        if (marksCompare != 0)
            return marksCompare;

        return this.Age.CompareTo(other.Age); 
        return 1;
    }
}



class Que_4
{
    public static void main()
    {
        List<Student1> students = new List<Student1>
        {
            new Student1 { Name = "Sandeep", Age = 21, Marks = 85 },
            new Student1 { Name = "Raman", Age = 19, Marks = 92 },
            new Student1 { Name = "Satyam", Age = 20, Marks = 92 },
            new Student1 { Name = "Akshat", Age = 22, Marks = 85 }
        };

        var sortedStudents = students.OrderByDescending(s => s.Marks).ThenBy(s => s.Age).ToList();

        foreach (var s in sortedStudents)
        {
            Console.WriteLine(s.Name+" "+s.Marks+" "+s.Age);
        }
        Console.WriteLine();
        Console.WriteLine();
        
        List<Student1> student1 = new List<Student1>
        {
            new Student1 { Name = "Sandeep", Age = 21, Marks = 85 },
            new Student1 { Name = "Raman", Age = 19, Marks = 92 },
            new Student1 { Name = "Satyam", Age = 20, Marks = 92 },
            new Student1 { Name = "Akshat", Age = 22, Marks = 85 }
        };
        student1.Sort();

        foreach (var s in student1)
        {
            Console.WriteLine(s.Name+" "+s.Marks+" "+s.Age);
        }
    }
}
