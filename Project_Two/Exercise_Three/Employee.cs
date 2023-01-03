namespace Exercise_Three
{
    public class Employee : IComparable<Employee>
    {
        // Fields
        private Company _company;


        // Properties
        public string Name { get; set; }
        public string Phone { get; set; }
        public Company Company
        {
            get { return _company; }
            set
            {
                if (_company == null)
                {
                    if (value != null)
                    {
                        _company = value;
                        _company.Employees.Add(this);
                    }
                }
                else
                {
                    if (value == null)
                    {
                        Resign(value);
                    }
                    else
                    {
                        try
                        {
                            if (value.IsAnEmployee(this))
                            {
                                throw new EmployeeException("This new company already contains the employee!");
                            }
                            else
                            {
                                Resign(value);
                                _company = value;
                                _company.Employees.Add(this);
                            }
                        }
                        catch (EmployeeException exp)
                        {
                            Console.WriteLine(exp.Message);
                        }
                    }
                }
            }
        }


        // Constructors
        public Employee(string name, string phone)
        {
            Name = name;
            Phone = phone;
        }


        // Methods
        public void ResignEmployee()
        {
            try
            {
                if (Company == null)
                {
                    throw new EmployeeException("We cannot fire unemployed employee!");
                }
                else
                {
                    Company = null;
                }
            }
            catch (EmployeeException exp)
            {
                Console.WriteLine(exp.Message);
            }
        }
        public override string ToString()
        {
            if (Company == null)
            {
                return $"EmployeeName = {Name} & EmployeePhone = {Phone}";
            }
            else
            {
                return $"EmployeeName = {Name} & EmployeePhone = {Phone} & EmployeeCompany = {Company.Name}";
            }
        }
        private void Resign(Company value)
        {
            Company oldCompany = _company;
            _company = value;
            Employee employee = oldCompany.Employees.FirstOrDefault(emp => emp.Name == Name && emp.Phone == Phone);
            if (employee != null)
            {
                oldCompany.Employees.Remove(employee);
            }
        }
        public int CompareTo(Employee? employee)
        {
            return Name.CompareTo(employee.Name);
        }
    }
}