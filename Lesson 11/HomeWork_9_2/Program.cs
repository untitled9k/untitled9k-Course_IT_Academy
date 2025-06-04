namespace HomeWork_9_2;

class Program
{
    static void Main(string[] args)
    {
        var products = new Dictionary<string, double>
        {
            { "Milk", 129},
            { "Bread", 60},
            { "Chicken", 349},
            { "Apples", 51},
            { "Eggs", 90},
            { "Meat", 625},
        };

        Console.WriteLine("List of products ant their prices: ");
        PrintProducts(products);

        Console.WriteLine("_________________________________");
        Console.WriteLine("Enter a product name to search:");
        string? input;

        do
        {
            Console.Write("Product name: ");
            input = Console.ReadLine();

            if(string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Input can't be empty.");
                continue;
            }

            if(!IsOnlyLetters(input))
            {
                Console.WriteLine("Input must contain only letters.");
                continue;
            }

            break;

        } while(true);

        SearchProduct(products, input);

        Console.WriteLine("\nIncreasing all prices 10%");
        IncreasePrices(products, 0.1);

        Console.WriteLine("Updated list of products:");
        PrintProducts(products);
    }

    static bool IsOnlyLetters(string input)
    {
        foreach (var c in input)
        {
            if (!char.IsLetter(c) && !char.IsWhiteSpace(c))
                return false;
        }

        return true;
    }

    static void PrintProducts(Dictionary<string, double> products)
    {
        foreach (var product in products)
        {
            Console.WriteLine($"{product.Key}: {product.Value:F2}");
        }
    }

    static void IncreasePrices(Dictionary<string, double> products, double percentage)
    {
        var keys = new List<string>(products.Keys);

        foreach (var key in keys)
        {
            products[key] *= 1 + percentage;
        }
    }

    static void SearchProduct(Dictionary<string, double> products, string? productName)
    {
        if (string.IsNullOrWhiteSpace(productName))
        {
            Console.WriteLine("Product name can't be empty");
            return;
        }

        foreach (var item in products)
        {
            if (string.Equals(item.Key, productName, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"Price of '{item.Key}': {item.Value}");
                return;
            }
        }

        Console.WriteLine($"Product '{productName}' not found.");
    }
}
