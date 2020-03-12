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

            // 1 is neither prime nor composite. So start at 2
            for (int i = 2; i <= target; i++)
            {
                for (j = 2; j < i; j++)
                {
                    // A number is not prime if it is divisible by any other number,
                    // other than 1 and itself.
                    if (i % j == 0)
                    {
                        isNumberComposite = true;
                        // We can break out of the inner for loop as we know the number
                        // is not prime
                        break;
                    }

                }
                // Print the number if it is not composite
                if (!isNumberComposite)
                    Console.Write($"{j}, ");
                else
                    isNumberComposite = false;

            }

        }
    }
}
