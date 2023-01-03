namespace Exercise_Two
{
    public abstract class Employee
    {
        // Properties
        public int Id { get; }
        public string FirstName { get; }
        public string LastName { get; }
        public double Age { get; }


        // Constructors
        public Employee(int id, string firstName, string lastName, double age)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }


        // Methods
        public virtual void Display()
        {
            Console.WriteLine($"Id = {Id}");
            Console.WriteLine($"FirstName = {FirstName}");
            Console.WriteLine($"LastName = {LastName}");
            Console.WriteLine($"Age = {Age}");
        }
        public abstract double CalculateSalary();
    }
}