namespace Exercise_Two
{
    public class Producer : Employee
    {
        // Fields
        private int _numberOfUnits;


        // Constructors
        public Producer(int id , string firstName, string lastName, double age, int numberOfUnits) : base(id, firstName, lastName, age)
        {
            _numberOfUnits = numberOfUnits;
        }


        // Methods
        public override double CalculateSalary()        // Implementation which is mandatory
        {
            return _numberOfUnits * 5;
        }
        public override void Display()                  // Re-implementation which is optional
        {
            base.Display();
            Console.WriteLine($"Number Of Units = {_numberOfUnits}");
        }
    }
}