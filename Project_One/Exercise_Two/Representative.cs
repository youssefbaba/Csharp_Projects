namespace Exercise_Two
{
    public class Representative : Commercial
    {
        // Constructors
        public Representative(int id, string firstName, string lastName, double age, double income) : base(id, firstName, lastName, age, income)
        {
        }


        // Methods
        public override double CalculateSalary()
        {
            return (Income * 0.2) + 800;
        }
    }
}