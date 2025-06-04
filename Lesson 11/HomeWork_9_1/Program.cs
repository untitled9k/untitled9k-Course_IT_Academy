namespace HomeWork_9_1;

class Program
{
    static void Main(string[] args)
    {
        var students = new List<Student>()
        {
            new ("Kate", 30, 4.9),
            new ("Peter", 35, 4.6),
            new ("Nickolay", 28, 4.1),
            new ("Vladimir", 25, 5),
            new ("Veronika", 30, 3.8),
            new ("Aleksander", 31, 4.9),
        };

        var sortedStudents = SortByAverageDescending(students);

        Console.WriteLine("List of sorted students: ");
        foreach (var student in sortedStudents)
        {
            student.PrintInformation();
        }

        var youngest = FindYoungestStudent(students);

        Console.WriteLine("\nYongest student: ");
        youngest.PrintInformation();
    }

    static List<Student> SortByAverageDescending(List<Student> students)
    {
        var sorted = new List<Student>(students);

        for(var i = 0; i < sorted.Count - 1; ++i)
        {
            for(var j= i + 1; j < sorted.Count; ++j)
            {
                if (sorted[j].AverageGrade > sorted[i].AverageGrade)
                {
                    var temp = sorted[i];
                    sorted[i] = sorted[j];
                    sorted[j] = temp;
                }
            }
        }

        return sorted;
    }

    static Student FindYoungestStudent(List<Student> students)
    {
        var youngest = students[0];

        foreach (var student in students) 
        {
            if(student.Age < youngest.Age)
            {
                youngest = student;
            }
        }

        return youngest;
    }
}
