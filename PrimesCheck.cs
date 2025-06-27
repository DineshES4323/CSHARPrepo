using System;Add commentMore actions

class PrimeCheck
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        bool isPrime = true;

        if (number <= 1) isPrime = false;

        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
            {
                isPrime = false;
                break;
            }
        }

        Console.WriteLine(isPrime ? "Prime" : "Not Prime");
    }
}
