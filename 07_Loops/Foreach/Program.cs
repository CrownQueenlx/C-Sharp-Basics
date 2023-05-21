namespace ForeachLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            // class system.Console {
            // string instructorName = "Amanda";
            string instructorName = "Shelby";
            string[] instructors = new string[] { "Michael", "Joshua", instructorName };

            // structure of Foreach loop
            //      variable of i value, "in" req,   iterated over
            // foreach (declaredIterator in enumerableCollection)
            // {body;
            // }

            foreach (string name in instructors)
            {
                Console.WriteLine(name);
            }

            // Exercise
            int[] integers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            // Declare new array of ints
            // static void while (i <= 20)
            // {
            //     return (i);
            //     i += i++;
            // } ;

            // int[] integers = new int [] {i};

            // Interate over arrat w foreach loop

            foreach (int i in integers)
            {
                // Write to the console wheather or not the numbers are negative or postitive.
                if (i > 0)
                {
                    Console.WriteLine($"{i} is a positive number.");
                }
                else
                {
                    Console.WriteLine($"{i} is a negative number.");
                }
                if (i % 2 == 0)
                {
                    Console.WriteLine($"{i} is an even number");
                }
                else
                {
                    Console.WriteLine($"{i} is an odd number");

                }
            }
        }
    }
}