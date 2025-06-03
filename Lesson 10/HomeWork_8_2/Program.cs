using System.Text;

namespace HomeWork_8_2;
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
        }while (true);

        Console.WriteLine("String without spaces: " + RemoveSpaces(input));
    }

    static string RemoveSpaces(string input)
    {
        var sb = new StringBuilder();

        foreach (char c in input)
        {
            if(c != ' ')
            {
                sb.Append(c);
            }
        }

        return sb.ToString();
    }
}
