using System.Data.Common;

namespace Exercise_Three
{
    public class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student(100, "Sam", "Doe");
            student1.AddMarkInSubject("English", 14);
            student1.AddMarkInSubject("Math", 16);
            student1.AddMarkInSubject("Computer Science", 15);
            student1.AddMarkInSubject("English", 16);
            student1.AddMarkInSubject("Math", 15);
            student1.AddMarkInSubject("Computer Science", 18);
            student1.DisplayMark("English");
            student1.DisplayMark("Math");
            student1.DisplayMark("Computer Science");
            Console.WriteLine();
            Student student2 = new Student(101, "Adam", "Gea");
            student2.AddMarkInSubject("English", 15);
            student2.AddMarkInSubject("Math", 17);
            student2.AddMarkInSubject("Computer Science", 13);
            student2.AddMarkInSubject("English", 14);
            student2.AddMarkInSubject("Math", 17);
            student2.AddMarkInSubject("Computer Science", 17);
            student2.DisplayMark("English");
            student2.DisplayMark("Math");
            student2.DisplayMark("Computer Science");
            Console.WriteLine();
            Group group1 = new Group();
            group1.AddStudent(student1);
            group1.AddStudent(student2);
            group1.DisplayStudents("English");
            group1.DisplayStudents("Math");
            group1.DisplayStudents("Computer Science");
            group1.DisplayAverageGroup("English");
            group1.DisplayAverageGroup("Math");
            group1.DisplayAverageGroup("Computer Science");
            Console.WriteLine($"Max Mark In English : {group1.MaxMark("English")}");
            Console.WriteLine($"Max Mark In Math : {group1.MaxMark("Math")}");
            Console.WriteLine($"Max Mark In Computer Science : {group1.MaxMark("Computer Science")}");
            group1.Histogram("English");

        }
    }
}