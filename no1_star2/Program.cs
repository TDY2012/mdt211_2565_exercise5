using System;

class Program
{
    static void Hamlet(int round)
    {
        if(round > 0)
        {
            Console.WriteLine("Hamlet");
            Hamlet(round - 1);
        }
    }

    static void Main(string[] args)
    {
        int round = int.Parse(Console.ReadLine());
        Hamlet(round);
    }
}
