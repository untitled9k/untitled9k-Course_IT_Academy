using System.Text;

namespace HomeWork_8_1;
class Program
{
    static void Main(string[] args)
    {
        string? input;

        do
        {
            Console.WriteLine("Enter a string:");
            input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("The string mustn't be empty.\n");
                continue;
            }

            bool hasLetters = false;

            foreach(char c in input)
            {
                if(char.IsLetter(c))
                {
                    hasLetters = true;
                    break;
                }
            }

            if(!hasLetters)
            {
                Console.WriteLine("Please enter at least one letter.");
                continue;
            }

            break;

        }while(true);

        if (IsPalindrome(input))
        {
            Console.WriteLine("It's palindrome!");
        }
        else
        {
            Console.WriteLine("Not palindrome.");
        }
    }

    static bool IsPalindrome(string input)
    {
        var sb = new StringBuilder();
        foreach (char c in input)
        {
            if(char.IsLetter(c))
            {
                sb.Append(char.ToLower(c));
            }
        }

        var cleaned = sb.ToString();

        var i = 0;
        var j = cleaned.Length - 1;

        while (i < j)
        {
            if (cleaned[i] != cleaned[j])
            {
                return false;
            }

            ++i;
            --j;
        }

        return true;
    }
}
