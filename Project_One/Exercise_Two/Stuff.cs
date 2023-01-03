namespace Exercise_Two
{
    public class Stuff
    {
        // Fields
        private Employee[] _arrayEmployees;
        private int _index;


        // Constructors
        public Stuff()
        {
            _arrayEmployees = new Employee[1000];
            _index = 0;
        }


        // Methods
        public void AddEmployee(Employee employee)
        {
            bool check = false;
            for (int i = 0; i < _index; i++)
            {
                if (_arrayEmployees[i].Id == employee.Id)
                {
                    check = true;
                }
            }
            if (!check)
            {
                if (_index < _arrayEmployees.Length)
                {
                    _arrayEmployees[_index] = employee;
                    _index++;
                }
                else
                {
                    Console.WriteLine("No space available for adding new employee!");
                }
            }
            else
            {
                Console.WriteLine("we cannot add an employee that is in this list of employess!");
            }
        }
        public void Display()
        {
            for (int i = 0; i < _index; i++)
            {
                Console.WriteLine($"#### Employee {i + 1} ####");
                _arrayEmployees[i].Display();
            }
        }
        public double AverageSalary()
        {
            double sum = default;
            double average = default;
            if (_index > 0)
            {
                for (int i = 0; i < _index; i++)
                {
                    sum += _arrayEmployees[i].CalculateSalary();
                }
                average = sum / _index;
            }
            return average;
        }
        public void NumberOfEmployees()
        {
            int NumberOfProducers = default;
            int NumberOfSellers = default;
            int NumberOfRepresentatives = default;
            for (int i = 0; i < _index; i++)
            {
                switch (_arrayEmployees[i].GetType().Name)
                {
                    case "Producer":
                        NumberOfProducers++;
                        break;
                    case "Seller":
                        NumberOfSellers++;
                        break;
                    case "Representative":
                        NumberOfRepresentatives++;
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine($"In this company we have {NumberOfSellers} Seller, {NumberOfProducers} Producer, {NumberOfRepresentatives} Representative");
        }
        public void Sort(int choice)
        {
            switch (choice)
            {
                case 1:
                    _arrayEmployees = _arrayEmployees.Take(_index).OrderBy(emp => emp.FirstName).ToArray();
                    Display();
                    break;
                case 2:
                    _arrayEmployees = _arrayEmployees.Take(_index).OrderBy(emp => emp.LastName).ToArray();
                    Display();
                    break;
                case 3:
                    _arrayEmployees = _arrayEmployees.Take(_index).OrderByDescending(emp => emp.Age).ToArray();
                    Display();
                    break;
            }
        }
    }
}