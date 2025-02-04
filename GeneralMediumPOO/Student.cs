using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralMediumPOO
{
    internal class Student
    {
        public string Name { get; private set; }
        private double[] _grades;

        public double Media()
        { 
            return CalcMedia();
        }

        public Student(string name, int exams)
        {
            Name = name;
            _grades = new double[exams];
        }

        public void SetGrades()
        {
            for (int i = 0; i < _grades.Length; i++)
            {
                Console.Write("Grade #" + (i + 1) + ": ");
                _grades[i] = double.Parse(Console.ReadLine());
            }
        }

        private double CalcMedia()
        {
            double total = 0;
            for (int i = 0; i < _grades.Length; i++)
            {
               total += _grades[i];
            }

            return total / _grades.Length;
        }
    }
}
