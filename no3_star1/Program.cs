using System;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        int numOperand = int.Parse(Console.ReadLine());
        int firstOperand = int.Parse(Console.ReadLine());
        int secondOperand;
        int gcd = firstOperand;

        while(numOperand - 1 > 0)
        {
            secondOperand = int.Parse(Console.ReadLine());
            gcd = (int)BigInteger.GreatestCommonDivisor(gcd, secondOperand);
            numOperand--;
        }
        
        Console.WriteLine(gcd);
    }
}
