using System;
namespace Part_1;

public class GuessingGame06
{
    public static void Run()
    {
        int answer = new Random().Next(1, 4);
        Console.Write("Guess a number (1–3): ");
        int guess = int.Parse(Console.ReadLine());

        if (guess < 1 || guess > 3)
            Console.WriteLine("Invalid: must be between 1 and 3.");
        else if (guess < answer)
            Console.WriteLine("Too low!");
        else if (guess > answer)
            Console.WriteLine("Too high!");
        else
            Console.WriteLine("Correct!");
    }
}