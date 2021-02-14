using System;
using Utilities;

class Program
{
    static void Main(string[] args)
    {
        int row = 0;

        do
        {
            if (row == 0 || row >= 25)
                ResetConsole();

            Console.WriteLine("Welcome to my adding machine!");

            Console.WriteLine("Enter the first number...");
            var num1 = Console.ReadLine();
            if (string.IsNullOrEmpty(num1)) break;

            Console.WriteLine("Enter the second number...");
            var num2 = Console.ReadLine();
            if (string.IsNullOrEmpty(num2)) break;

            var total = Calcultions.AddTwoNumbers(num1, num2);

            Console.WriteLine("Your total is: " + total.ToString());

            row += 3;
        } while (true);
        return;

        // Declare a ResetConsole local method
        void ResetConsole()
        {
            if (row > 0)
            {
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
            Console.Clear();
            Console.WriteLine("\nPress <Enter> only to exit; otherwise, enter a string and press <Enter>:\n");
            row = 3;
        }
    }
}