namespace HomeWork_4_4;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a character to move: \nW - up, \nA - left, \nS - down, \nD - right.");

        bool valid = false;


        while (!valid)
        {
            char input = Console.ReadKey().KeyChar;
            Console.WriteLine();

            switch (input)
            {
                case 'W':
                case 'w':
                    Console.WriteLine("The figure moved up.");
                    valid = true;
                    break;
                case 'S':
                case 's':
                    Console.WriteLine("The figure moved down.");
                    valid = true;
                    break;
                case 'A':
                case 'a':
                    Console.WriteLine("The figure moved left.");
                    valid = true;
                    break;
                case 'D':
                case 'd':
                    Console.WriteLine("The figure moved right.");
                    valid = true;
                    break;
                default:
                    Console.WriteLine("No movement required.");
                    break;
            }
        }
        
    }
}
