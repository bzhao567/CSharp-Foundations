using System;
namespace Part_1;

public class Playground01 {
    public static void Run()
    {
        Console.Write("Favorite color? ");
        string color = Console.ReadLine();
        Console.Write("Astrology sign? ");
        string sign = Console.ReadLine();
        Console.Write("Street number? ");
        string num = Console.ReadLine();

        Console.WriteLine($"Your hacker name is {color}{sign}{num}.");
    }
}