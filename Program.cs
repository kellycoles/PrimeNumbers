using System;

namespace PrimeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare a boolean variable to determine is if a number is prime
            bool isNumberComposite = false;
            int j;


            // Prompt the user to enter their target number
            Console.WriteLine("Enter your Target?");


            // Read the target number and convert to integer
            int target = Int32.Parse(Console.ReadLine());
        }
    }
}
