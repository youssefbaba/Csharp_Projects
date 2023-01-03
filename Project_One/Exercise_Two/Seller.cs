namespace Exercise_Two
{
    public class Seller : Commercial
    {
        // Constructors
        public Seller(int id, string firstName, string lastName, double age, double income) : base(id, firstName, lastName, age, income)
        {
        }


        // Methods
        public override double CalculateSalary()
        {
            return (Income * 0.2) + 400;
        }
    }
}