using System;

class Program
{
    static void Main(string[] args)
    {
        int level = int.Parse(Console.ReadLine());
        int total = 4*level*(level+1)*(2*level + 1)/6 - 4*level*(level+1)/2 + level;
        Console.WriteLine(total);
    }
}
