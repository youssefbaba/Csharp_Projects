namespace Exercise_One
{
    public class Program
    {

        static void Main(string[] args)
        {
            ClassOne obj = new ClassOne();
            ClassOne obj1 = new ClassOne();
            //Console.WriteLine($"{obj.NumberOne} And {obj1.NumberTwo}");     // We cannot be accessed to static member by using an instance reference , instead of that we can use directly name of the class.
            Console.WriteLine($"{ClassOne.NumberOne} And {obj1.NumberTwo}");     // 2 And 2


            ClassTwo obj2 = new ClassFour(); // because obj2 is reference of parent class created by using child class instance (pointer) and obj2 cannot be accessible to any child member only its members.
            obj2.Method();      // Class Two

            ClassSix obj3 = new ClassSix();           // Parameterless constructor of child class (ClassSix) implicitly calls to prameterless constructor of parent class (ClassFive)
            ClassSix obj4 = new ClassSix(2003);       // Parameterized constructor that takes integer value as parameter of child class (ClassSix) explicitly calls to prameterless constructor of the same class and after that this constructor will implicitly call to prameterless constructor of the parent class (ClassFive) .
            ClassSix obj5 = new ClassSix("Hello");    // Parameterized constructor that takes string value as parameter of child class (ClassSix) explicitly calls to prameterless constructor of the parent class (ClassFive) .
            Console.WriteLine($"{obj3.Number} And {obj4.Number} And {obj5.Number}"); // 6 And 2009 And 4

        }
    }
}