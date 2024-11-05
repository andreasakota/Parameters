using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comparables
{
    class Student : IComparable
    {
        private string name;
        private double grade;

        public Student(string name, double grade)
        {
            this.name = name;
            this.grade = grade;
        }

        public override string ToString()
        {
            return name +": " + grade;
        }
        public int CompareTo(object? obj)
        {
            if (obj == null) return 1 ;

            Student otherStudent = obj as Student;

            if (otherStudent != null)
                return this.grade.CompareTo(otherStudent.grade);
            else
                throw new ArgumentException("Object is not a Student");
         }
    }
}
