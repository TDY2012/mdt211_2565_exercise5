using System;

class Program
{
    static void Main(string[] args)
    {
        int level = int.Parse(Console.ReadLine());

        for(int i=0; i<level-1; i++)
        {
            Console.Write(" ");
        }
        Console.WriteLine("#");
        for(int i=1; i<level-1; i++)
        {
            for(int j=0; j<level-1-i; j++)
            {
                Console.Write(" ");
            }
            Console.Write("#");
            for(int j=0; j<2*i-1; j++)
            {
                Console.Write(" ");
            }
            Console.WriteLine("#");
        }

        if(level>1)
        {
            for(int i=0; i<2*level-1; i++)
            {
                Console.Write("#");
            }
        }
    }
}
