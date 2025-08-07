using System;

namespace Part_1;

public class CenturyConverter03
{
    public static void Run()
    {
        Console.Write("Enter number of centuries: ");
        int c = int.Parse(Console.ReadLine());

        long years = c * 100L;
        long days = years * 365 + years/4 - years/100 + years/400;
        long hours = days * 24;
        long minutes = hours * 60;
        long seconds = minutes * 60;
        decimal ms = seconds * 1_000M;
        decimal us = ms * 1_000M;
        decimal ns = us * 1_000M;

        Console.WriteLine(
            "{0} centuries = {1,5} years = {2,8} days = {3,10} hours = {4,12} minutes\n" +
            "{5,14} seconds = {6,15} milliseconds = {7,18} microseconds = {8,21} nanoseconds",
            c, years, days, hours, minutes,
            seconds, ms, us, ns
        );
    }
}