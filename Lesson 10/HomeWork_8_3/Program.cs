using System.Text;

namespace HomeWork_8_3;
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

            break;
        } while (true);

        Console.WriteLine("__________________");
        Console.WriteLine("Small letters: " + input.ToLower());
        Console.WriteLine("Big letters: " + input.ToUpper());
        Console.WriteLine("First letter of word is big: " + FirstBigLetter(input));
    }

    static string FirstBigLetter(string input)
    {
        var sb = new StringBuilder();
        bool newWord = true;

        foreach (char c in input)
        {
            if(char.IsWhiteSpace(c))
            {
                sb.Append(c);
                newWord = true;
            }
            else
            {
                sb.Append(newWord ? char.ToUpper(c) : char.ToLower(c));
                newWord = false;
            }
        }

        return sb.ToString();
    }
}