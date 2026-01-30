using System;

class Que_17
{
    public static void main()
    {
        int initialBalance = 1000;
        int[] transactions = { 500, -200, -1500, 300, -400 };

        int balance = initialBalance;

        foreach (int t in transactions)
        {
            if (t >= 0)
            {
                balance += t;
            }
            else
            {
                if (balance + t >= 0)
                {
                    balance += t;
                }
            }
        }

        Console.WriteLine(balance);
    }
}
