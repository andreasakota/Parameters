using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comparers
{
    public enum StudentComparerType { Name, Grade }

    public class StudentComparer : IComparer
    {
        private StudentComparerType criterion;

        public StudentComparer(StudentComparerType criterion)
        {
            this.criterion = criterion;
        }

        public int Compare(object x, object y)
        {
            Student student1 = x as Student;
            Student student2 = y as Student;

            if (criterion == StudentComparerType.Name)
                return student1.name.CompareTo(student2.name);
            else
                // Sortiranje po ocjeni u opadajućem redoslijedu
                return student2.grade.CompareTo(student1.grade);
        }

    }
}