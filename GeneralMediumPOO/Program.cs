using GeneralMediumPOO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralMediaPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Student Media";

            Console.WriteLine("How many students? ");
            int nStudents = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Student[] students = new Student[nStudents];

            for (int i = 0; i < students.Length; i++)
            {
                Console.Clear();
                Console.Write("Student #" + (i + 1) + " Name..: ");
                string name = Console.ReadLine();

                Console.Write("Student #" + (i + 1) + " Exams: ");
                int exams = int.Parse(Console.ReadLine());

                students[i] = new Student(name, exams);

                Console.WriteLine("Type the grades of student " + name);
                students[i].SetGrades();
            }

            Console.Clear();

            double generalMedia = 0;

            foreach (Student student in students)
            {
                Console.WriteLine("Student: " + student.Name);
                Console.WriteLine("Media..: " + student.Media().ToString("F2"));
                Console.WriteLine();
                generalMedia += student.Media();
            }

            double finalResult = generalMedia / students.Length;

            Console.WriteLine("General Media: " + finalResult.ToString("F2"));
        }
    }
}
