namespace Exercise_One
{
    public class ClassOne
    {
        // Fields
        //int _number;      //  Should be public to be inherited.
        public int Number { get; set; } // Solution 


        // Constructors
        public ClassOne(int number)
        {
            //_number = number;
            Number = number;    // Solution
        }
    }
}