namespace Exercise_Three
{
    public class Group
    {
        // Fields
        private List<Student> _listOfStudents;


        // Constructors
        public Group()
        {
            _listOfStudents = new List<Student>();
        }


        // Methods
        public void AddStudent(Student student)
        {
            if (student != null)
            {
                if (_listOfStudents.Exists(std => std.Id == student.Id))
                {
                    Console.WriteLine($"we cannot add this student , because is already in this group!");
                }
                else
                {
                    _listOfStudents.Add(student);
                }
            }
        }
        public void DisplayStudents(string subject)
        {
            if (subject != null)
            {
                Console.WriteLine($"#### Marks Of {subject} ####");
                _listOfStudents.Sort();
                foreach (Student student in _listOfStudents)
                {
                    Mark selectedMark;
                    if (student.DictionaryMarks.TryGetValue(subject, out selectedMark))
                    {
                        try
                        {
                            if (selectedMark.ListOfMarks.Count <= 0)
                            {
                                throw new NullReferenceException($"This student doesn't have any mark in {subject}!");
                            }
                            else
                            {
                                Console.Write($"{student.FirstName} {student.LastName} : ");
                                foreach (double mark in selectedMark.ListOfMarks)
                                {
                                    Console.Write($"{mark} ");
                                }
                                Console.WriteLine();
                            }
                        }
                        catch (NullReferenceException exp)
                        {
                            Console.WriteLine(exp.Message);
                        }
                    }

                }
            }

        }
        public void DisplayAverageGroup(string subject)
        {
            double average = default;
            double sum = default;
            if (_listOfStudents.Count > 0)
            {
                foreach (Student student in _listOfStudents)
                {
                    sum += student.AverageInSubject(subject);
                }
                average = sum / _listOfStudents.Count;
            }
            Console.WriteLine($"Average Of Marks for this group = {average}");
        }
        public double MaxMark(string subject)
        {
            List<double> marks = new List<double>();
            foreach (Student student in _listOfStudents)
            {
                marks.Add(student.AverageInSubject(subject));
            }
            return marks.Max();
        }
        public List<Student> AdmittedStudents(string subject)
        {
            List<Student> admittedStudents = new List<Student>();
            foreach (Student student in _listOfStudents)
            {
                if (student.AverageInSubject(subject) >= 12)
                {
                    admittedStudents.Add(student);
                }
            }
            return admittedStudents;
        }
        public void Histogram(string subject)
        {
            List<double> Average = new List<double>();
            //List<double> Average = new List<double>() { 16.3, 18, 15.7, 12.2, 15.9, 11.4, 11, 11.1 };

            foreach (Student student in _listOfStudents)
            {
                Average.Add(student.AverageInSubject(subject));
            }
            int minMark = (int)Average.Min();
            int maxMark = (int)Average.Max();
            for (int i = minMark - 1; i <= maxMark + 1; i++)
            {
                int counter = 0;
                Console.Write($"[{i} - {i + 1}[ ");
                foreach (double item in Average)
                {
                    if (item >= i && item < i + 1)
                    {
                        counter++;
                    }
                }
                for (int j = 0; j < counter; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}