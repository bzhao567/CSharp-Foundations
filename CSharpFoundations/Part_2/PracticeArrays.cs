using System;
namespace Part_2;

public class PracticeArrays
{
    public static void CopyArray()
    {
        int[] original = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        int[] copy = new int[original.Length];

        for (int i = 0; i < original.Length; i++)
            copy[i] = original[i];

        Console.WriteLine("Original: " + string.Join(", ", original));
        Console.WriteLine("Copy: " + string.Join(", ", copy));
    }

    public static void ListManager()
    {
        var list = new List<string>();

        while (true)
        {
            Console.WriteLine("Enter command (+ item, - item, or -- to clear):");
            string input = Console.ReadLine();

            if (input == "--")
                list.Clear();
            else if (input.StartsWith("+ "))
                list.Add(input.Substring(2));
            else if (input.StartsWith("- "))
                list.Remove(input.Substring(2));
            else
                Console.WriteLine("Invalid command.");

            Console.WriteLine("Current list: " + string.Join(", ", list));
        }
    }

    public static int[] Primes(int startNum, int endNum)
    {
        var primes = new List<int>();
        for (int n = Math.Max(2, startNum); n <= endNum; n++)
        {
            bool isPrime = true;
            for (int d = 2; d * d <= n; d++)
                if (n % d == 0) { isPrime = false; break; }
            if (isPrime) primes.Add(n);
        }
        return primes.ToArray();
    }

    public static void RotateAndSum()
    {
        int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int k = int.Parse(Console.ReadLine());

        int n = arr.Length;
        long[] sum = new long[n];

        for (int r = 1; r <= k; r++)
        {
            int[] rotated = new int[n];
            for (int i = 0; i < n; i++)
                rotated[(i + r) % n] = arr[i];

            Console.WriteLine($"rotated{r}: {string.Join(" ", rotated)}");
            for (int i = 0; i < n; i++)
                sum[i] += rotated[i];
        }

        Console.WriteLine("sum: " + string.Join(" ", sum));
    }

    public static void LongestSequence()
    {
        int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

        int bestVal = arr[0], bestLen = 1;
        int currVal = arr[0], currLen = 1;

        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] == currVal)
                currLen++;
            else
            {
                if (currLen > bestLen)
                {
                    bestLen = currLen;
                    bestVal = currVal;
                }
                currVal = arr[i];
                currLen = 1;
            }
        }
        if (currLen > bestLen) { bestLen = currLen; bestVal = currVal; }

        Console.WriteLine(string.Join(" ", Enumerable.Repeat(bestVal, bestLen)));
    }

    public static void MostFrequent()
    {
        int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
        var freq = new Dictionary<int, int>();
        int bestVal = arr[0], bestCount = 0;

        foreach (int x in arr)
        {
            if (!freq.ContainsKey(x)) freq[x] = 0;
            freq[x]++;
            if (freq[x] > bestCount)
            {
                bestCount = freq[x];
                bestVal = x;
            }
        }

        Console.WriteLine($"The number {bestVal} is most frequent ({bestCount} times).");
    }
}