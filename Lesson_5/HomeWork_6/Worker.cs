namespace HomeWork_6;

class Worker : EmployeeBase
{
    public string Departament;
    
    public Worker(string name, string departament): base (name, "Worker")
    {
        Departament = departament;
    }
    public override void GetDetails()
    {
        Console.WriteLine($"Worker: {Name}, Position: {Position}, Departament: {Departament}");
    }
}
