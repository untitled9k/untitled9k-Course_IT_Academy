namespace HomeWork_6;
class Manager : EmployeeBase
{
    private Project[] projects = new Project[0];
    private int projectCount = 0;

    public Manager(string name) : base(name, "Manager") { }

    public void AddProject(Project project)
    {
        if (projectCount < projects.Length)
        {
            projects[projectCount] = project;
            projectCount++;
        }

    }

    public override void GetDetails()
    {
        Console.WriteLine($"Manager: {Name}, Position: {Position}");
        for(int i = 0; i< projectCount; ++i)
        {
            projects[i].DisplayProjectInfo();       
        }
    }

    public class Project
    {
        public string ProjectName;
        public DateTime Deadline;

        public Project(string projectName, DateTime deadline)
        {
            ProjectName = projectName;
            Deadline = deadline;
        }

        public void DisplayProjectInfo()
        {
            Console.WriteLine($"Project: {ProjectName}, Deadline: {Deadline.ToShortDateString}");
        }
    }
}
