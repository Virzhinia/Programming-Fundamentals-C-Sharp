using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Average_Student_Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var grades = new Dictionary<string, List<double>>();

            for (int i = 0; i < n; i++)
            {
               var student = Console.ReadLine().Split(new char[] {' '},StringSplitOptions.RemoveEmptyEntries);
                var name = student[0];
                var grade = double.Parse(student[1]);

                if(grades.ContainsKey(name))
                {
                    grades[name].Add(grade);
                }
                else
                {
                    grades[name] = new List<double>() { grade };
                }
            }

            foreach (var student in grades)
            {
                var studentGrades = student.Value;
                var avg =studentGrades.Average();

                Console.Write($"{student.Key} -> ");
                foreach (var grade in studentGrades)
                {
                    Console.Write($"{grade:f2} ");
                }
                Console.WriteLine($"(avg: {avg:f2})");
            }
        }
    }
}
