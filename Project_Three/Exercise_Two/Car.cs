namespace Exercise_Two
{
    public class Car
    {
        // Properties
        public int Registration { get; set; }
        public string Brand { get; set; }
        public double RentalPrice { get; set; }


        // Constructors
        public Car(int registration, string brand, double rentalPrice)
        {
            Registration = registration;
            Brand = brand;
            RentalPrice = rentalPrice;
        }


        // Methods
        public override string ToString()
        {
            return $"Registration = {Registration} & Brand = {Brand} & RentalPrice = {RentalPrice}";
        }
    }
}