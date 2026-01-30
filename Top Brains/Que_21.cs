using System;

class Que_21
{
    static T[] Merge<T>(T[] a, T[] b) where T : IComparable<T>
    {
        T[] result = new T[a.Length + b.Length];

        int i = 0, j = 0, k = 0;

        while (i < a.Length && j < b.Length)
        {
            if (a[i].CompareTo(b[j]) <= 0)
            {
                result[k++] = a[i++];
            }
            else
            {
                result[k++] = b[j++];
            }
        }

        while (i < a.Length)
        {
            result[k++] = a[i++];
        }

        while (j < b.Length)
        {
            result[k++] = b[j++];
        }

        return result;
    }

    public static void main()
    {
        int[] a = { 1, 3, 5, 7 };
        int[] b = { 2, 4, 6, 8 };

        int[] merged = Merge(a, b);

        foreach (int x in merged)
        {
            Console.Write(x + " ");
        }
    }
}
