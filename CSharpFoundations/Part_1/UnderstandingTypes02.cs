using System;

namespace Part_1;

public class UnderstandingTypes02
{
    public static void Run()
    {
        Print("sbyte",  sizeof(sbyte),  sbyte.MinValue,  sbyte.MaxValue);
        Print("byte",   sizeof(byte),   byte.MinValue,   byte.MaxValue);
        Print("short",  sizeof(short),  short.MinValue,  short.MaxValue);
        Print("ushort", sizeof(ushort), ushort.MinValue, ushort.MaxValue);
        Print("int",    sizeof(int),    int.MinValue,    int.MaxValue);
        Print("uint",   sizeof(uint),   uint.MinValue,   uint.MaxValue);
        Print("long",   sizeof(long),   long.MinValue,   long.MaxValue);
        Console.WriteLine($"{ "ulong",-7} | {sizeof(ulong),2} bytes | {ulong.MinValue,20:N0} to {ulong.MaxValue,20:N0}");
        
        Console.WriteLine();
        Console.WriteLine($"{"float",-7} | {sizeof(float),2} bytes | {float.MinValue,12:E} to {float.MaxValue,12:E}");
        Console.WriteLine($"{"double",-7}| {sizeof(double),2} bytes | {double.MinValue,12:E} to {double.MaxValue,12:E}");
        Console.WriteLine($"{"decimal",-7}| {sizeof(decimal),2} bytes | {decimal.MinValue,20:N0} to {decimal.MaxValue,20:N0}");
    }
    
    static void Print(string name, int size, long min, long max)
    {
        Console.WriteLine($"{name,-7} | {size,2} bytes | {min,20:N0} to {max,20:N0}");
    }
}