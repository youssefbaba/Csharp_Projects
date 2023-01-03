namespace Exercise_One
{
    internal class ClassSix : ClassFive
    {
        // Constructors
        public ClassSix()
        {
            Number++;
        }
        public ClassSix(int value):this()
        {
            Number += value;
        }
        public ClassSix(string str):base()
        {
            Number--;
        }
    }
}