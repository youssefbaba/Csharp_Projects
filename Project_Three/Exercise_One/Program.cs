namespace Exercise_One
{
    public class Program
    {
        static void Main(string[] args)
        {
            //ITest obj = new ITest(); // We cannot create an instance from an interface , typically we use interface for implemetation.
            Test obj = new Test();
            obj.Display();

            ClassOne obj1 = new ClassThree();  // because obj1 is reference of parent class created by using child class instance (pointer) so obj1 cannot be accessible to any child member only its members.
            obj1.Method(); // ClassOne

            /*
             - Why C# doesn't support multiple inheritance :
                - C# doesn’t support the multiple inheritance because of the ambiguity issue. Lets take an example we have three classes ClassParent1, ClassParent2 and ClassChild now suppose ClassChild inherits from the class ClassParent1 and ClassParent2 something like that
                Class ClassChild:ClassParent1,ClassParent2 now suppose both classes ClassParent1 and ClassParent2 have a function with the name Demo(). Now if you will create the object of ClassChild class and try to call that Demo() function at that time compiler will get confuse weather to call Demo from ClassParent1 or from ClassParent2 class,
                This is the reason why C# doesn’t support multiple inheritance .
             */
        }
    }
}