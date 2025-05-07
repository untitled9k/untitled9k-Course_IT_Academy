namespace homeWork_3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write your age:");
            int age;
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out age) && age >= 0)
                    break;
                Console.WriteLine("Age isn't correct.");
            }

            if(age%2 == 0)
            {
                Console.WriteLine("Your age is even.");
            }
            else
            {
                Console.WriteLine("Your age is odd.");
            }


            string ageGroup;
            if (age >= 0 && age <= 2)
                ageGroup = "Baby";
            else if (age >= 3 && age <= 12)
                ageGroup = "Child";
            else if (age >= 13 && age <= 17)
                ageGroup = "Teenager";
            else if (age >= 18 && age <= 59)
                ageGroup = "Adult";
            else
                ageGroup = "Old";

            Console.WriteLine($"You are in {ageGroup} age group.");
        }
    }
}
