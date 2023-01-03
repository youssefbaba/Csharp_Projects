namespace Exercise_Three
{
    public class Program
    {
        public static void Main()
        {
            Company company1 = new Company("Berexia");
            Company company2 = new Company("SQLI");
            Employee employee1 = new Employee("Marks", "1234567890");
            Employee employee2 = new Employee("David", "7894567890");
            company1.HireEmployee(employee1);
            company1.HireEmployee(employee2);
            Employee employee3 = new Employee("Sam", "4865967890");
            Employee employee4 = new Employee("Jim", "4973267890");
            company2.HireEmployee(employee3);
            company2.HireEmployee(employee4);
            Console.WriteLine($"{company1}");
            Console.WriteLine();
            Console.WriteLine($"{company2}");
            company1.FireEmployee(employee2);
            company2.FireEmployee(employee4);
            Console.WriteLine();
            Console.WriteLine($"{company1}");
            Console.WriteLine();
            Console.WriteLine($"{company2}");

            Director director1 = new Director("ahmedDirecteur", "1234567877", 120000);
            Director.CreateDirector(director1, company2);
            Console.WriteLine($"{company2}");
            Console.WriteLine($"{director1}"); 
            Console.WriteLine();
            //********** Another Employees ************************** 
            Employee employee5 = new Employee("Karime", "1239997811");
            Employee employee6 = new Employee("Nada", "1234567888");
            Employee employee7 = new Employee("René", "1234567777");
            Employee employee8 = new Employee("Bernard", "1234567547");
            company2.HireEmployee(employee5);
            company2.HireEmployee(employee5);
            company2.HireEmployee(employee6);
            company1.HireEmployee(employee7);
            company1.HireEmployee(employee8);
            //************ After we add another employees ************
            Console.WriteLine($"{company1}");
            Console.WriteLine($"{company2}");

            //************ Karime and Bernard Resigne. ***************
            employee5.ResignEmployee();
            employee8.ResignEmployee();
            Console.WriteLine($"{company1}");
            Console.WriteLine($"{company2}");

            //*********** ahmedDirecteur moves to Berexia **************************************
            company1.HireEmployee(new Director("redaDirecteur", "7896567877", 130000));
            //company1.HireEmployee(director1);
            Console.WriteLine($"Director of Berexia {company1.Director}");
            Console.WriteLine($"Director of SQLI {company2.Director}");
            Console.WriteLine($"{company1}");
            Console.WriteLine($"{company2}");
            Console.WriteLine();
            //company1.HireEmployee(new Director("youssefDirecteur", "7896567865", 115000));
            company1.HireEmployee(director1);
            Console.WriteLine($"Director of Berexia {company1.Director}");
            Console.WriteLine($"Director of SQLI {company2.Director}");
            Console.WriteLine($"{company1}");
            Console.WriteLine($"{company2}");
            //************ Change of director **************************
            Director director2 = new Director("FaridDirecteur", "1234567877", 100000);
            Director.CreateDirector(director2, company2);  // SQLI
            Console.WriteLine($"{director2}");
            Console.WriteLine($"{company1}");
            Console.WriteLine($"{company2}");
            company1.HireEmployee(director2);
            Console.WriteLine($"{company1}");
            Console.WriteLine($"{company2}");
        }
    }
}