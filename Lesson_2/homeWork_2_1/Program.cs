namespace homeWork_2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write your name:");
            var name = Console.ReadLine();

            Console.WriteLine("Write your age:");
            int age;
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out age) && age >= 0)
                    break;
                Console.WriteLine("Age isn't correct.");
            }


            double height;
            while (true)
            {
                Console.WriteLine("Write your height:");
                if (double.TryParse(Console.ReadLine(), out height))
                    break;
                Console.WriteLine("Height isn't correct.");
            }

            Console.WriteLine("***************************************");
            Console.WriteLine($"Hi, {name}!\n\tYour age: {age}.\n\t\tYour height: {height}.");
            Console.WriteLine("***************************************");
        }
    }
}
