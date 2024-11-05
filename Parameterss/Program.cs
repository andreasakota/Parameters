namespace Parameterss
{
    class Program
    {
        public static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        static void Main(string[] args)
        {

            int a = 1;
            int b = 2;

            
            Console.WriteLine("a = " + a + " " + "b = " + b);

            
            Swap(ref a, ref b);

            
            Console.WriteLine("After: a = " + a + " " + "b = " + b);

            
            int[] array = { 2, 3, 4, 1, 8, 6, 5, 7 };
            Console.WriteLine("\nBefore: ");
            DisplayArray(array);

          
            Swap(ref array[2], ref array[3]);

          
            Console.WriteLine("\nAfter: ");
            DisplayArray(array);

        }
        static void DisplayArray(int[] array)
        {
            foreach (int value in array)
            {
                Console.Write(value + " ");
            }
            Console.WriteLine();
        }
    }
}
