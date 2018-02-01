using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Average_Grades
{
    class Student
    {
        public string Name { get; set; }
        public List<double> Grades { get; set; }
        public double Average { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader(@"../../input.txt");

            List<Student> record = new List<Student>();

            while (!reader.EndOfStream)
            {
                int input = int.Parse(reader.ReadLine());

                for (int i = 0; i < input; i++)
                {
                    List<string> tokens = reader.ReadLine().Split().ToList();

                    string name = tokens[0];

                    List<double> grades = new List<double>();
                    tokens.RemoveAt(0);
                    grades.AddRange(tokens.Select(double.Parse));

                    double average = grades.Average();

                    Student current = new Student()
                    {
                        Name = name,
                        Grades = grades,
                        Average = average
                    };

                    record.Add(current);
                }

                foreach (Student stud in record.Where(x => x.Average >= 5)
                                           .OrderBy(x => x.Name)
                                           .ThenByDescending(x => x.Average))
                {
                    File.AppendAllText(@"../../output.txt", stud.Name + " -> " + string.Format("{0:f2}", stud.Average) + Environment.NewLine);
                }

                record = new List<Student>();
            }
            reader.Close();
        }
    }
}
