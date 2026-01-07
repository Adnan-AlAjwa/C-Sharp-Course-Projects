using System;

namespace PackageExpress
{
    class Program
    {
        static void Main(string[] args)
        {
            // The first line of the program must be the welcome message
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            // Prompt the user for the package weight
            Console.WriteLine("Please enter the package weight:");
            // Convert the user input string into a decimal for calculation
            decimal weight = Convert.ToDecimal(Console.ReadLine());

            // Check if weight is greater than 50
            if (weight > 50)
            {
                // Display error message if the package is too heavy
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                // End the program
                return;
            }

            // Prompt the user for the package width
            Console.WriteLine("Please enter the package width:");
            // Store the width input
            decimal width = Convert.ToDecimal(Console.ReadLine());

            // Prompt the user for the package height
            Console.WriteLine("Please enter the package height:");
            // Store the height input
            decimal height = Convert.ToDecimal(Console.ReadLine());

            // Prompt the user for the package length
            Console.WriteLine("Please enter the package length:");
            // Store the length input
            decimal length = Convert.ToDecimal(Console.ReadLine());

            // Check if the sum of dimensions (width + height + length) is greater than 50
            if ((width + height + length) > 50)
            {
                // Display error message if the dimensions are too large
                Console.WriteLine("Package too big to be shipped via Package Express.");
                // End the program
                return;
            }

            // Calculate the quote: (Width * Height * Length * Weight) / 100
            decimal quote = (width * height * length * weight) / 100;

            // Display the quote to the user formatted as a dollar amount (C2 = Currency)
            Console.WriteLine("Your estimated total for shipping this package is: " + quote.ToString("C2"));
            
            // Final closing message
            Console.WriteLine("Thank you!");
            
            // Keep the console window open until a key is pressed (useful for debugging)
            Console.ReadLine();
        }
    }
}
