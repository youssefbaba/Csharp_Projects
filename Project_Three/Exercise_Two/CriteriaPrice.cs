namespace Exercise_Two
{
    public class CriteriaPrice : ICriteria
    {
        // Fields
        private double _price;


        // Constructors
        public CriteriaPrice(double price)
        {
            _price = price;
        }


        // Methods
        public bool IsSatisfiedBy(Car car)
        {
            return (car.RentalPrice == _price) ? true : false;
        }
    }
}
