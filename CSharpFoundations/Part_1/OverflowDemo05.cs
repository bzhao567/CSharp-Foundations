using System;
namespace Part_1;

public class OverflowDemo05
{
    public static void Run()
    {
        try                                     //added a try-catch block to avoid the overflow bug
        {
            checked
            {
                int max = 500;                  //since i is a byte, if we run this inner code by itself, it will never reach 500, and just loop endlessly
                for (byte i = 0; i < max; i++)
                {
                    Console.WriteLine(i);
                }
            }
        }
        catch (OverflowException)
        {
            Console.WriteLine("Overflow Detected");
        }
        
    }
}