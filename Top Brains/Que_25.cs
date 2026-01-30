using System;

class Que_25
{
    public static void main()
    {
        string expression = "10 / 2";

        string result;

        string[] parts = expression.Split(' ');

        if (parts.Length != 3)
        {
            result = "Error:InvalidExpression";
        }
        else
        {
            int a, b;

            if (!int.TryParse(parts[0], out a) || !int.TryParse(parts[2], out b))
            {
                result = "Error:InvalidNumber";
            }
            else
            {
                string op = parts[1];

                if (op == "+")
                {
                    result = (a + b).ToString();
                }
                else if (op == "-")
                {
                    result = (a - b).ToString();
                }
                else if (op == "*")
                {
                    result = (a * b).ToString();
                }
                else if (op == "/")
                {
                    if (b == 0)
                    {
                        result = "Error:DivideByZero";
                    }
                    else
                    {
                        result = (a / b).ToString();
                    }
                }
                else
                {
                    result = "Error:UnknownOperator";
                }
            }
        }

        Console.WriteLine(result);
    }
}
