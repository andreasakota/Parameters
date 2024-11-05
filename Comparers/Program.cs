namespace Comparers
{
    class Program
    {
        static void Main()
        {
            Student[] students = {
            new Student("Ivo", 4.1),
            new Student("Ana", 4.9),
            new Student("Iva", 4.3),
            new Student("Bob", 4.5),
            new Student("Joe", 4.7)
        };

            Console.WriteLine("Prije sortiranja:");
            foreach (Student student in students)
                Console.WriteLine(student);

            // Sortiranje po imenu
            StudentComparer comparer = new StudentComparer(StudentComparerType.Name);
            Bubble.Sort(students, comparer);
            Console.WriteLine("\nSortirano po imenu:");
            foreach (Student student in students)
                Console.WriteLine(student);

            // Sortiranje po ocjeni
            comparer = new StudentComparer(StudentComparerType.Grade);
            Bubble.Sort(students, comparer);
            Console.WriteLine("\nSortirano po ocjeni:");
            foreach (Student student in students)
                Console.WriteLine(student);
        }
    }

}
