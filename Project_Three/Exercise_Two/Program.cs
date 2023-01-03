namespace Exercise_Two
{
    public class Program
    {
        public static void Main(String[] args)
        {
            Car car1 = new Car(123, "Fiat", 12000);
            Car car2 = new Car(555, "BMW", 20000);
            Car car3 = new Car(147, "Mercedes", 35000);
            Car car4 = new Car(963, "Toyota", 15000);
            ListCars listCars = new ListCars();
            listCars.AddCar(car1);
            listCars.AddCar(car2);
            listCars.AddCar(car3);
            listCars.AddCar(car4);
            listCars.DisplayCars();
            Console.WriteLine();
            listCars.RemoveCar(car2);
            listCars.DisplayCars();
        }
    }
}