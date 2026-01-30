using System;
using System.Collections.Generic;

interface IArea
{
    double GetArea();
}

abstract class Shape : IArea
{
    public abstract double GetArea();
}

class Circle : Shape
{
    double r;

    public Circle(double r)
    {
        this.r = r;
    }

    public override double GetArea()
    {
        return Math.PI * r * r;
    }
}

class Rectangle : Shape
{
    double w;
    double h;

    public Rectangle(double w, double h)
    {
        this.w = w;
        this.h = h;
    }

    public override double GetArea()
    {
        return w * h;
    }
}

class Triangle : Shape
{
    double b;
    double h;

    public Triangle(double b, double h)
    {
        this.b = b;
        this.h = h;
    }

    public override double GetArea()
    {
        return 0.5 * b * h;
    }
}

class Que_20
{
    public static void main()
    {
        string[] shapes =
        {
            "C 5",
            "R 4 6",
            "T 3 8"
        };

        double totalArea = 0;

        foreach (string s in shapes)
        {
            string[] parts = s.Split(' ');
            Shape shape = null;

            if (parts[0] == "C")
            {
                shape = new Circle(double.Parse(parts[1]));
            }
            else if (parts[0] == "R")
            {
                shape = new Rectangle(double.Parse(parts[1]), double.Parse(parts[2]));
            }
            else if (parts[0] == "T")
            {
                shape = new Triangle(double.Parse(parts[1]), double.Parse(parts[2]));
            }

            totalArea += shape.GetArea();
        }

        totalArea = Math.Round(totalArea, 2, MidpointRounding.AwayFromZero);

        Console.WriteLine(totalArea);
    }
}
