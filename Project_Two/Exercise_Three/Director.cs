namespace Exercise_Three
{
    public class Director : Employee
    {
        // Fields
        private double _salary;


        // Constructors
        public Director(string name, string phone , double salary) : base(name, phone)
        {
            _salary = salary;
        }


        // Methods
        public static void CreateDirector(Director director, Company company) 
        {
            if (company != null)
            {
                if (company.Director != null)
                {
                    return;
                }
                else
                {
                    Director newDirector = director;
                    company.HireEmployee(newDirector);
                }
            }
        }
        public override string ToString()
        {
            if (Company == null)
            {
                return $"DirectorName = {Name} & DirectorPhone = {Phone} & Salary = {_salary}";
            }
            else
            {
                return $"DirectorName = {Name} & DirectorPhone = {Phone} & DirectorCompany = {Company.Name} & Salary = {_salary}";
            }
        }
    }
}