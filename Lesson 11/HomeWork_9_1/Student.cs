namespace HomeWork_9_1;

class Student
{
    private string _name;
    private int _age;
    private double _averageGrade;

    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    public int Age
    {
        get { return _age; }
        set { _age = value; }
    }

    public double AverageGrade
    {
        get { return _averageGrade; }
        set { _averageGrade = value; }
    }

    public Student(string name, int age, double averageGrade)
    {
        _name = name;
        _age = age;
        _averageGrade = averageGrade;
    }

    public void PrintInformation()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}, Avarage grade: {AverageGrade}");
    }
}
