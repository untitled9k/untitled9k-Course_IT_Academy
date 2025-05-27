namespace HomeWork_7_2_;
class Program
{
    static void Main(string[] args)
    {
        var n = 3;
        var array = new int[n, n];

        Console.WriteLine("Enter numbers for matrix 3x3");
        for (int row = 0; row < n; ++row)
        {
            for (int col = 0; col < n; ++col)
            {
                while (true)
                {
                    Console.Write($"Number [{row},{col}]: ");
                    if (int.TryParse(Console.ReadLine(), out int value))
                    {
                        array[row, col] = value;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Please enter number!");
                    }
                }
            }
        }

        Console.WriteLine("___________________________");
        Console.WriteLine("MAX numbers of rows");

        for (int row = 0; row < 3; ++row)
        {
            int max = array[row, 0];
            for (int col = 1; col < 3; ++col)
            {
                if (array[row, col] > max)
                {
                    max = array[row, col];
                }
            }
            Console.WriteLine($"Row {row + 1}: {max}");
        }
    }
}