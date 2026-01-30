using System;
using System.Collections.Generic;

static class Extensions
{
    public static IEnumerable<T> DistinctBy<T, TKey>(this IEnumerable<T> source, Func<T, TKey> keySelector)
    {
        HashSet<TKey> seen = new HashSet<TKey>();

        foreach (var item in source)
        {
            if (seen.Add(keySelector(item)))
                yield return item;
        }
    }
}

class Que_23
{
    public static void main()
    {
        string[] items =
        {
            "1:John",
            "2:Alice",
            "1:Mark",
            "3:David",
            "2:Emma"
        };

        List<string> result = new List<string>();

        foreach (var item in items.DistinctBy(x => x.Split(':')[0]))
        {
            result.Add(item.Split(':')[1]);
        }

        Console.WriteLine(string.Join(" ", result));
    }
}
