using System;

class Program
{
    static int ChainGCD(int numOperand, int firstOperand)
    {
        if(numOperand > 0)
        {
            int secondOperand = int.Parse(Console.ReadLine());
            return ChainGCD(numOperand - 1, GCD(firstOperand, secondOperand));
        }
        return firstOperand;
    }

    static int GCD(int firstOperand, int secondOperand)
    {
        if(secondOperand == 0)
        {
            return firstOperand;
        }
        else
        {
            return GCD(secondOperand, firstOperand % secondOperand);
        }
    }

    static void Main(string[] args)
    {
        int numOperand = int.Parse(Console.ReadLine());
        int firstOperand = int.Parse(Console.ReadLine());
        int gcd = ChainGCD(numOperand - 1, firstOperand);

        Console.WriteLine(gcd);
    }
}
