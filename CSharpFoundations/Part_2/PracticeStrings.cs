using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
namespace Part_2;

public class PracticeStrings
{
    public static void ReverseString()
    {
        string s = Console.ReadLine();

        // Method 1: ToCharArray + Array.Reverse
        char[] arr = s.ToCharArray();
        Array.Reverse(arr);
        Console.WriteLine(new string(arr));

        // Method 2: for-loop
        for (int i = s.Length - 1; i >= 0; i--)
            Console.Write(s[i]);
        Console.WriteLine();
    }

    public static void ReverseWords()
    {
        string input = Console.ReadLine();
        if (input == null) return;

        const string pattern = @"[^ \.\,\:\;\=\(\)\&\[\]""'\\/!\?]+";

        var reversedWords = Regex.Matches(input, pattern)
                                 .Cast<Match>()
                                 .Select(m => m.Value)
                                 .Reverse()
                                 .ToArray();

        int index = 0;
        string output = Regex.Replace(input, pattern, _ => reversedWords[index++]);

        Console.WriteLine(output);
    }

    public static void ExtractPalindromes()
    {
        var separators = new HashSet<char>(
            new[] { '.', ',', ':', ';', '=', '(', ')', '&', '[', ']', '"',
                '\'', '\\', '/', '!', '?', ' ' });

        string line = Console.ReadLine();

        var words = new List<string>();
        var sb = new System.Text.StringBuilder();
        foreach (char ch in line)
        {
            if (!separators.Contains(ch))
            {
                sb.Append(ch);
            }
            else if (sb.Length > 0)
            {
                words.Add(sb.ToString());
                sb.Clear();
            }
        }
        if (sb.Length > 0)
            words.Add(sb.ToString());

        var palindromes = words
            .Where(w => IsPalindrome(w))
            .Distinct()
            .OrderBy(w => w, StringComparer.OrdinalIgnoreCase);

        Console.WriteLine(string.Join(", ", palindromes));
    }
    
    private static bool IsPalindrome(string s)
    {
        for (int i = 0, j = s.Length - 1; i < j; i++, j--)
            if (s[i] != s[j])
                return false;
        return true;
    }

    public static void URLParser()
    {
        string input = Console.ReadLine();
        string protocol = "", server = "", resource = "";

        int p = input.IndexOf("://");
        if (p >= 0)
        {
            protocol = input.Substring(0, p);
            input = input.Substring(p + 3);
        }

        int s = input.IndexOf('/');
        if (s >= 0)
        {
            server = input.Substring(0, s);
            resource = input[(s + 1)..];
        }
        else
        {
            server = input;
        }

        Console.WriteLine($"[protocol] = \"{protocol}\"");
        Console.WriteLine($"[server]   = \"{server}\"");
        Console.WriteLine($"[resource] = \"{resource}\"");
    }
}