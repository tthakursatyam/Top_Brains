using System.Collections.Generic;
namespace Top_Brains
{
    class Que_12
    {
        public static void main()
        {
            List<string> values = new List<string>();

            Console.Write("Enter number of inputs:");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string str = Console.ReadLine();
                values.Add(str);
            }
            Dictionary<string, int> keyValues = new Dictionary<string, int>();
            foreach (var i in values)
            {
                string[] temp = i.Split(",");
                if (temp.Length > 1)
                {
                    if (keyValues.ContainsKey(temp[0]))
                    {
                        Console.WriteLine("Username already exits");
                    }
                    else
                    {
                        keyValues[temp[0]] = Convert.ToInt32(temp[1]);
                    }
                }
            }
            var res = keyValues.OrderByDescending(x => x.Value).Take(3).Select(x => x.Key).ToList();
            foreach(var i in res)
            {
                Console.Write(i+" ");
            }
        }
    }
}