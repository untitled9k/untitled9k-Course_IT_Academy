namespace HomeWork_5;

class Program
{
    static void Main(string[] args)
    {
        Book book1 = new Book();
        Console.WriteLine(book1.GetDescription());

        Book book2 = new Book("CLR via C#", "Richer D.", 895);
        Console.WriteLine(book2.GetDescription());

        Book book3 = new Book("Programming language C#", "Troelson E.", 1235);
        Console.WriteLine(book3.GetDescription());
    }
}
