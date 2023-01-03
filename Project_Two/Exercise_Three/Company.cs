namespace Exercise_Three
{
    public class Company
    {
        // Fields
        private Director _director;


        // Properties
        public string Name { get; set; }
        public List<Employee> Employees { get; }
        public Director Director
        {
            get { return _director; }
            set
            {
                if (_director != null)
                {
                    _director.ResignEmployee();
                    _director = value;
                }
                else
                {
                    if (value != null)
                    {
                        _director = value;
                    }
                }
            }
        }


        // Constructors
        public Company(string name)
        {
            Name = name;
            Employees = new List<Employee>();
        }


        // Methods
        public bool IsAnEmployee(Employee employee)
        {
            if (employee != null)
            {
                if (employee.Company == null)
                {
                    return false;
                }
                else
                {
                    return Employees.Exists(emp => emp.Name == employee.Name && emp.Phone == employee.Phone);
                }
            }
            return false;
        }

        public void HireEmployee(Employee employee)
        {
            if (employee != null)
            {
                try
                {
                    if (IsAnEmployee(employee))
                    {
                        throw new EmployeeException("We cannot hire an employee who is already working in this company!");
                    }
                    else
                    {
                        Company oldCompany = employee.Company;
                        if (employee.Company == null)
                        {
                            employee.Company = this;
                        }
                        else
                        {
                            if (employee.GetType().Name == "Director")
                            {
                                employee.Company.Director = null;
                            }
                            employee.ResignEmployee();
                            employee.Company = this;
                        }
                        if (employee.GetType().Name == "Director")
                        {
                            Director = (Director)employee;
                        }
                    }
                }
                catch (EmployeeException exp)
                {
                    Console.WriteLine(exp.Message);
                }
            }

        }
        public void FireEmployee(Employee employee)
        {
            if (employee != null)
            {
                try
                {
                    if (!IsAnEmployee(employee))
                    {
                        throw new EmployeeException("We cannot fire an employee who is not working in this company!");
                    }
                    else
                    {
                        employee.ResignEmployee();
                        if (employee.GetType().Name == "Director")
                        {
                            Director = null;
                        }
                    }
                }
                catch (EmployeeException exp)
                {
                    Console.WriteLine(exp.Message);
                }
            }

        }
        public override string ToString()
        {
            string result = string.Empty;
            Employees.Sort();
            foreach (Employee employee in Employees)
            {
                result += $"{employee}\n";
            }
            return $"CompanyName = {Name}\n{result}";
        }
    }
}