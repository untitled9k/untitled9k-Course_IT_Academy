using System.Text.RegularExpressions;

namespace HomeWork_9_3;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter text:");
        string? input = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(input))
        {
            Console.WriteLine("The text mustn't be empty.");
            return;
        }

        var cleanedInput = Regex.Replace(input.ToLower(), @"[^\w\s]", "");
        var words = cleanedInput.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        var wordCount = new Dictionary<string, int>();

        foreach (var word in words)
        {
            if (wordCount.TryGetValue(word, out var count))
            {
                wordCount[word] = count + 1;
            }               
            else
            {
                wordCount[word] = 1;
            }    
        }

        Console.WriteLine("\nUnique words and their number:");
        foreach (var pair in wordCount)
        {
            Console.WriteLine($"{pair.Key} - {pair.Value}");
        }

        int uniqueCount = 0;
        foreach (var pair in wordCount)
        {
            if (pair.Value == 1)
            {
                uniqueCount++;
            }
        }

        Console.WriteLine($"\nNumber of uniq words: {uniqueCount}");
    }
}