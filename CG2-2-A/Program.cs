using System;

namespace CG2_2_A
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("We are going to find the area of a rectangle.");
            Console.Write("How many inches is the length of your rectangle? ");
            int rectangleLength = Convert.ToInt32(Console.ReadLine());

            Console.Write("How many inches is the height of your rectangle? ");
            int rectangleHeight = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Your rectangle is " + rectangleHeight * rectangleLength + " square inches.");
            Console.ReadLine();
        }
    }
}
