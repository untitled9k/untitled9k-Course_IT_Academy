namespace HomeWork_4_3;

class Program
{
    static void Main(string[] args)
    {
        var number = -20;

        do
        {
            Console.WriteLine(number);
            number -= 20;
        } while (number >= -100);
    }
}