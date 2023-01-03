namespace Exercise_Three
{
    public class Mark
    {
        // Properties
        public List<double> ListOfMarks { get; }


        // Constructors
        public Mark()
        {
            ListOfMarks = new List<double>();
        }


        // Methods
        public void AddMark(double mark)
        {
            ListOfMarks.Add(mark);
        }
    }
}