using System;
namespace Part_1;

public class AgeCalculator08
{
    public static void Run()
    {
        Console.Write("Enter birthdate (yyyy-MM-dd): ");
        DateTime dob = DateTime.Parse(Console.ReadLine());
        DateTime now = DateTime.Now;

        int daysOld = (now - dob).Days;
        Console.WriteLine($"You are {daysOld} days old.");

        int toNext = 10000 - (daysOld % 10000);
        DateTime nextAnn = now.AddDays(toNext);
        Console.WriteLine($"Your next 10,000-day anniversary is {nextAnn:yyyy-MM-dd}.");
    }
}