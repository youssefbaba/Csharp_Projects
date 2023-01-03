namespace Exercise_One
{
    public class ClassTwo : ClassOne
    {
        // Field
        int _value;


        // Constrctors
        //public ClassOne(int number)     // Name of constructor should be the same as the name of the class , and have int value as another parameter
        public ClassTwo(int number, int value) : base(number)    // Solution
        {
            //_number = number;
            _value = value;
        }
    }
}