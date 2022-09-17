using System;

class Program
{
    static void Main(string[] args)
    {
        string firstPosition, lastPosition;
        int firstYear, lastYear;

        firstPosition = Console.ReadLine();
        lastPosition = firstPosition;
        firstYear = int.Parse(Console.ReadLine());
        lastYear = firstYear;

        string inputPosition;
        int inputYear;
        while(lastYear != 2565)
        {
            inputPosition = Console.ReadLine();
            inputYear = int.Parse(Console.ReadLine());

            if(inputYear < firstYear)
            {
                firstYear = inputYear;
                firstPosition = inputPosition;
            }
            else if(inputYear > lastYear)
            {
                lastYear = inputYear;
                lastPosition = inputPosition;
            }
        }

        Console.WriteLine(firstPosition);
        Console.WriteLine(firstYear);
        Console.WriteLine(lastPosition);
        Console.WriteLine(lastYear);
        Console.WriteLine(lastYear - firstYear + 1);
    }
}
