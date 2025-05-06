namespace homeWork_3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first boolean value (true/false)");
            var input1 = Console.ReadLine().ToLower();
            while (input1 != "true" && input1 != "false")
            {
                Console.WriteLine("Invalid input!");
                input1 = Console.ReadLine().ToLower();
            }
            var firstValue= input1 == "true";


            Console.WriteLine("Enter second boolean value (true/false)");
            var input2 = Console.ReadLine().ToLower();
            while (input2 != "true" && input2 != "false")
            {
                Console.WriteLine("Invalid input!");
                input2 = Console.ReadLine().ToLower();
            }
            var secondValue = input2 == "true";

            Console.WriteLine("______________________________________________");
            Console.WriteLine("p\tq\tp&q\tp|q\tp^q\t!p\t");
            Console.WriteLine("______________________________________________");
            Console.WriteLine($"{firstValue}\t{secondValue}\t{firstValue && secondValue}\t{firstValue || secondValue}\t" +
                              $"{firstValue ^ secondValue}\t{!firstValue}");

        }
    }
}
