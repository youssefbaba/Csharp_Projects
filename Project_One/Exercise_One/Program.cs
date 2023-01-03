namespace Exercise_One
{
    public class Program
    {
        static void Main(string[] args)
        {
            //ClassFour obj = new ClassFour();    // we cannot create an instance from an abstract class , typically we use abstract classes for inheritance
            ClassThree obj1 = new ClassThree();
            obj1.Display();
        }
    }
}