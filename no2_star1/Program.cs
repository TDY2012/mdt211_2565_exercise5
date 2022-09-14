using System;

class Program
{
    static void Main(string[] args)
    {
        int level = int.Parse(Console.ReadLine());
        int total = 0;
        for(int i=1; i<=level; i++)
        {
            total += (2*i - 1)*(2*i - 1);
        }
        Console.WriteLine(total);
    }
}
