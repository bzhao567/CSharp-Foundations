using System;
namespace Part_1;

public class PrintAPyramid07
{
    public static void Run()
    {
        int rows = 5;
        for (int r = 0; r < rows; r++)
        {
            // spaces
            for (int s = 0; s < rows - r - 1; s++)
                Console.Write(" ");
            // stars
            for (int st = 0; st < (2 * r + 1); st++)
                Console.Write("*");
            Console.WriteLine();
        }
    }
}