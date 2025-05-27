namespace HomeWork_6;

static class EmployeeRegistry
{
    private static EmployeeBase[] employees = new EmployeeBase[100];
    private static int count = 0;

    public static void AddEmployee(EmployeeBase employee)
    {
        if (count < employees.Length)
        {
            employees[count] = employee;
            count++;
        }
    }

    public static void ListAllEmployees()
    {
        Console.WriteLine("List of employees: ");
        for(int i = 0; i < count; i++)
        {
            employees[i].GetDetails();
            
        }
    }

    public static void FindEmployee(string name)
    {
        for(int i = 0; i < count; i++)
        {
            if(employees[i].Name == name)
            {
                Console.WriteLine("Employee found!");
                employees[i].GetDetails();
                return;
            }
        }
        Console.WriteLine("Employee not found!");
    }
}
