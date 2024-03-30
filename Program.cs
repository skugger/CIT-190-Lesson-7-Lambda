namespace CIT_190_Lesson_7_Lambda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Random rand = new Random();
            // double one = Math.Round((rand.NextDouble() * 100), 2);
            // double two = Math.Round((rand.NextDouble() * 100), 2);
            // Console.WriteLine();
            // Console.WriteLine($"Generated two random numbers - {one} and {two}.");

            Console.WriteLine();
            Console.WriteLine("Enter a number: ");
            double one = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter another number: ");
            double two = double.Parse(Console.ReadLine());
            Console.WriteLine();

            var sum = (double one, double two) => one + two;
            var product = (double one, double two) => one * two;
            var smaller = (double one, double two) =>
            {
                if (one < two)
                    return one;
                else
                    return two;
            };

            Console.WriteLine($"The sum of your two numbers is {sum(one, two)}.");
            Console.WriteLine($"The product of your two numbers is {product(one, two)}.");
            Console.WriteLine($"The smaller of your two numbers is {smaller(one, two)}.");
        }
    }
}
