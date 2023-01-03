namespace Exercise_Two
{
    public class Customer : IComparable<Customer>
    {
        // Properties
        public int Code { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }


        // Constructors
        public Customer(int code, string firstName, string lastName)
        {
            Code = code;
            FirstName = firstName;
            LastName = lastName;
        }


        // Methods
        public override string ToString()
        {
            return $"Code = {Code} & FirstName = {FirstName} & LastName = {LastName}"; 
        }

        public int CompareTo(Customer? customer)
        {
            return -FirstName.CompareTo(customer.FirstName);
        }
    }
}