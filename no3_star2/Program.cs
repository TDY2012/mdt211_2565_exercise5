using System;

class Program
{
    static void Main(string[] args)
    {
        int numOperand = int.Parse(Console.ReadLine());
        int firstOperand = int.Parse(Console.ReadLine());
        int secondOperand, tmp;
        int gcd = firstOperand;
        while(numOperand - 1 > 0)
        {
            secondOperand = int.Parse(Console.ReadLine());
            while(secondOperand != 0)
            {
                tmp = firstOperand;
                firstOperand = secondOperand;
                secondOperand = tmp % secondOperand;
            }
            gcd = firstOperand;
            numOperand--;
        }

        Console.WriteLine(gcd);
    }
}
