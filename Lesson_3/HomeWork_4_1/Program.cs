namespace HomeWork_4_1;

    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[10];
            Random rnd = new Random();

            for(int i = 0; i < numbers.Length; ++i)
            {
                numbers[i] = rnd.Next(100);
                
            }

            Console.WriteLine("Loop 'for'");
            for(int i = 0; i < numbers.Length; ++i)
            {
                Console.Write(numbers[i] + " ");
            }

            Console.WriteLine("\n\nLoop 'foreach'");
            foreach (int num in numbers)
            {
                Console.Write(num + " ");
            }

            Console.WriteLine("\n\nLoop 'while'");
            int j = 0;
            while (j < numbers.Length)
            {
                Console.Write(numbers[j] + " ");
                ++j;
            }

            Console.WriteLine("\n\nLoop 'do-while'");
            int k = 0;
            do
            {
                Console.Write(numbers[k] + " ");
                k++;
            } while (k < numbers.Length);
        }
    }
