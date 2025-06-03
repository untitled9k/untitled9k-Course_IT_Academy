namespace HomeWork_7;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = new int[6];

        Console.WriteLine("Enter 6 numbers: ");
        for (int i = 0; i < numbers.Length; i++)
        {
            while (true)
            {
                Console.Write($"Number {i + 1}: ");
                var input = Console.ReadLine();

                if (int.TryParse(input, out int result))
                {
                    numbers[i] = result;
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter an integer number!");
                }

            }
        }

        for (int i = 0; i < numbers.Length - 1; ++i)
        {
            for (int j = i + 1; j < numbers.Length; ++j)
            {
                if (numbers[j] > numbers[i])
                {
                    int temp = numbers[i];
                    numbers[i] = numbers[j];
                    numbers[j] = temp;
                }
            }
        }

        Console.WriteLine("___________________________");
        Console.WriteLine("Sorted in descending order:");
        for (int i = 0; i < numbers.Length; ++i)
        {
            Console.Write($"{numbers[i]}  ");
        }
    }
}