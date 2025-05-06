namespace homeWork_2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double number1, number2;

            Console.WriteLine("Enter the first number:");
            while (!double.TryParse(Console.ReadLine(), out number1))
                Console.WriteLine("Invalid input.Please, try again!");

            Console.WriteLine("Enter the second number:");
            while (!double.TryParse(Console.ReadLine(), out number2))
                Console.WriteLine("Invalid input. Please, try again!");

            Console.WriteLine($"Sum: {number1}+{number2}={number1 + number2}");
            Console.WriteLine($"Subtraction: {number1}-{number2}={number1 - number2}");
            Console.WriteLine($"Multiplication: {number1}*{number2}={number1 * number2}");

            if (number2 != 0)
                Console.WriteLine($"Division: {number1}/{number2}={number1 / number2}");
            else
                Console.WriteLine("Division by 0 isn't possible!");
        }
    }
}
