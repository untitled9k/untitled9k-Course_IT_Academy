namespace HomeWork_6;

class Program
{
    static void Main(string[] args)
    {
        Manager manager1 = new Manager("Angelina");
        manager1.AddProject(new Manager.Project("Ololo game", DateTime.Now.AddDays(25)));

        Worker worker1 = new Worker("Kate", "Developer");
        Worker worker2 = new Worker("Jack", "Gamedesigner");
        Worker worker3 = new Worker("Bill", "Developer");

        EmployeeRegistry.AddEmployee(manager1);
        EmployeeRegistry.AddEmployee(worker1);
        EmployeeRegistry.AddEmployee(worker2);
        EmployeeRegistry.AddEmployee(worker3);

        EmployeeRegistry.ListAllEmployees();

        EmployeeRegistry.FindEmployee("Kate");
    }
}
