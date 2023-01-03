namespace Exercise_Two
{
    public abstract class Commercial : Employee
    {
        // Fields
        protected double Income;


        // Constructors
        public Commercial(int id, string firstName, string lastName, double age, double income) : base(id, firstName, lastName, age)
        {
            Income = income;
        }


        // Methods
        public override abstract double CalculateSalary();
        public sealed override void Display()      // Re-implementation which is optional
        {
            base.Display();
            Console.WriteLine($"Income = {Income}");
        }
    }
}