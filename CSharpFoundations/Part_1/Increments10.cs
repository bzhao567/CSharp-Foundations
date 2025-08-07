using System;
namespace Part_1;

public class Increments10
{
    public static void Run()
    {
        for (int step = 1; step <= 4; step++)
        {
            for (int i = 0; i <= 24; i += step)
            {
                Console.Write(i);
                if (i + step <= 24) Console.Write(",");
            }
            Console.WriteLine();
        }
    }
}