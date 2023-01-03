namespace Exercise_Two
{
    public class Agency
    {
        // Properties
        public string Name { get; set; }
        public ListCars Parking { get; set; }
        public Dictionary<Customer, ListCars> RentedCarCustomer { get; set; }


        // Constructors
        public Agency(string name)
        {
            Name = name;
            RentedCarCustomer = new Dictionary<Customer, ListCars>();
        }


        // Methods
        public void AddCar(Car car)
        {
            Parking.AddCar(car);
        }
        public void RemoveCar(Car car)
        {
            Parking.RemoveCar(car);
        }
        public void RentCustomerCar(Customer customer, Car car)
        {
            if (customer != null)
            {
                ListCars value;
                if (RentedCarCustomer.TryGetValue(customer, out value))
                {
                    value.AddCar(car);
                }
                else
                {
                    RentedCarCustomer.Add(customer, new ListCars());
                    RentCustomerCar(customer, car);
                }
            }
        }
        public List<Car> RentedCars()
        {
            List<Car> listOfRentedCars = new List<Car>();
            foreach (ListCars item in RentedCarCustomer.Values)
            {
                foreach (Car car in item.Cars)
                {
                    listOfRentedCars.Add(car);
                }
            }
            return listOfRentedCars;
        }
        public void DisplayCustomerCars()
        {
            List<Customer> listOfCustomers = RentedCarCustomer.Keys.ToList();
            listOfCustomers.Sort();
            foreach (Customer customer in listOfCustomers)
            {
                Console.WriteLine($"{customer}");
                foreach (Car car in RentedCarCustomer[customer].Cars)
                {
                    Console.WriteLine($"{car}");
                }
                Console.WriteLine("----------------------------------------------------");
            }
        }
        public List<Car> SelectCarByCriteria(ICriteria criteria)
        {
            List<Car> listCarsByCriteria = new List<Car>();
            foreach (Car car in Parking.Cars)
            {
                if (criteria.IsSatisfiedBy(car))
                {
                    listCarsByCriteria.Add(car);
                }
            }
            return listCarsByCriteria;
        }

    }
}