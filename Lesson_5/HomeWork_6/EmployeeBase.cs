namespace HomeWork_6
{
    abstract class EmployeeBase
    {
        public string Name {get; set;}
        public string Position {get; set;}

        protected EmployeeBase(string name, string position)
        {
            Name = name;
            Position = position;
        }

        public abstract void GetDetails();

    }
}
