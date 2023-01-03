namespace Exercise_Two
{
    public class ListCars
    {
        // Properties
        public List<Car> Cars { get; }


        // Constructors
        public ListCars()
        {
            Cars = new List<Car>();
        }
        public ListCars(List<Car> cars)
        {
            Cars = cars;
        }


        // Methods
        public void AddCar(Car car)
        {
            if (car != null)
            {
                try
                {
                    if (Cars.Exists(c => c.Registration == car.Registration && c.Brand == car.Brand))
                    {
                        throw new CarException("This car already exists in this car list!");
                    }
                    else
                    {
                        Cars.Add(car);
                    }
                }
                catch (CarException exp)
                {
                    Console.WriteLine(exp.Message);
                }
            }
        }
        public void RemoveCar(Car car)
        {
            if (car != null)
            {
                try
                {
                    if (!Cars.Exists(c => c.Registration == car.Registration && c.Brand == car.Brand))
                    {
                        throw new CarException("This car doesn't exist in this car list!");
                    }
                    else
                    {
                        Car selectedCar = Cars.FirstOrDefault(c => c.Registration == car.Registration && c.Brand == car.Brand);
                        if (selectedCar != null)
                        {
                            Cars.Remove(selectedCar);
                        }
                    }
                }
                catch (CarException exp)
                {
                    Console.WriteLine(exp.Message);
                }
            }
        }
        public void DisplayCars()
        {
            foreach (Car car in Cars)
            {
                Console.WriteLine($"{car}");
            }
        }
    }
}