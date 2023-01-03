namespace Exercise_Two
{
    public class Program
    {
        static void Main(string[] args)
        {
            Producer producer1 = new Producer(100, "David", "Gea", 45, 180);
            Producer producer2 = new Producer(101, "Bernard", "Silva", 36, 190);
            Seller seller1 = new Seller(102, "Marks", "Alonso", 30, 120000);
            Seller seller2 = new Seller(103, "Gerarad", "Pique", 31, 100000);
            Representative representative1 = new Representative(104, "Daniel", "Alves", 25, 100000);
            Representative representative2 = new Representative(105, "Sam", "Huge", 36, 120000);
            Representative representative3 = new Representative(106, "John", "Doe", 45, 110000);
            Stuff stuff = new Stuff();
            stuff.AddEmployee(producer1);
            stuff.AddEmployee(producer2);
            stuff.AddEmployee(seller1);
            stuff.AddEmployee(seller2);
            stuff.AddEmployee(representative1);
            stuff.AddEmployee(representative2);
            stuff.AddEmployee(representative3);
            stuff.Display();
            Console.WriteLine($"Average Salary = {stuff.AverageSalary()}");
            stuff.NumberOfEmployees();
            stuff.Sort(1);
        }
    }
}