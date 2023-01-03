namespace Exercise_Two
{
    public class CriteriaBrand : ICriteria
    {
        // Fields
        private string _brand;


        // Constructors
        public CriteriaBrand(string brand)
        {
            _brand = brand;
        }


        // Methods
        public bool IsSatisfiedBy(Car car)
        {
            return (car.Brand == _brand) ? true : false;
        }
    }
}
