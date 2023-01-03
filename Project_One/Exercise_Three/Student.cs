namespace Exercise_Three
{
    public class Student : IComparable<Student>
    {
        // Properties
        public int Id { get; }
        public string FirstName { get; }
        public string LastName { get; }
        public Dictionary<string, Mark> DictionaryMarks { get; }




        // Constructors
        public Student(int id, string firstName, string lastName)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            DictionaryMarks = new Dictionary<string, Mark>();
        }


        // Methods
        public void AddMarkInSubject(string subject, double mark)
        {
            if (subject != null)
            {
                Mark selectedMark;
                if (DictionaryMarks.TryGetValue(subject, out selectedMark))
                {
                    selectedMark.AddMark(mark);
                }
                else
                {
                    DictionaryMarks.Add(subject, new Mark());
                    AddMarkInSubject(subject, mark);
                }
            }
        }
        public double AverageInSubject(string subject)
        {
            double sum = default;
            double average = default;
            if (subject != null)
            {
                Mark selectedMark;
                if (DictionaryMarks.TryGetValue(subject, out selectedMark))
                {
                    try
                    {
                        if (selectedMark.ListOfMarks.Count <= 0)
                        {
                            throw new NullReferenceException($"This student doesn't have any mark in {subject}!");
                        }
                        else
                        {
                            foreach (double mark in selectedMark.ListOfMarks)
                            {
                                sum += mark;
                            }
                            average = sum / selectedMark.ListOfMarks.Count;
                        }
                    }
                    catch (NullReferenceException exp)
                    {
                        Console.WriteLine(exp.Message);
                    }
                }
            }
            return average;
        }
        public void DisplayMark(string subject)
        {
            Console.WriteLine($"Average Mark in {subject} for this student = {AverageInSubject(subject)}");
        }
        public int CompareTo(Student? student)
        {
            return FirstName.CompareTo(student.FirstName);
        }
    }
}