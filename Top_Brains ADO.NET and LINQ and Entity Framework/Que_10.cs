class Que_10
{
    public static void main()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        List<Employee> ls = new List<Employee>();
        for(int i=0;i<n;i++)
        {
            string[] str = Console.ReadLine().Split(" ");
            Employee ep = new Employee() 
            {
                Id=Convert.ToInt32(str[0]),
                Name=str[1],
                Depart=str[2],
                Salary=Convert.ToInt32(str[3])
            };
            ls.Add(ep);
        }
        var res=ls.Where(x=>x.Salary>50000).GroupBy(x=>x.Depart).ToDictionary(g => g.Key, g => g.ToList());

        foreach(var i in res)
        {
            Console.Write($"{i.Key} -> ");
            foreach(var x in i.Value)
            {
                Console.Write(x.Name+" ");
            }
            Console.WriteLine();
        }
    }
}
class Employee
{
    public int Id{get;set;}
    public string Name{get;set;}
    public string Depart{get;set;}
    public int Salary{get;set;}
}