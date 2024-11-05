namespace Comparables
{
    class Program
    {
        static void Main(string[] args)
        {
            Student[] students = {
                    new Student ("Ivo", 4.1),
                    new Student ("Ana", 4.9),
                    new Student ("Iva", 4.3),
                    new Student ("Bob", 4.5),
                    new Student ("Joe", 4.7)
            };

            Console.WriteLine("Before:");

            foreach (Student student in students)
            {
                Console.WriteLine(student);
            }

            Bubble.Sort(students);

            Console.WriteLine("After:");

            foreach (Student student in students)
            {
                Console.WriteLine(student);
            }
        }
    }
}
