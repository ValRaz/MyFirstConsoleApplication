using System;

namespace MyFirstConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            //Store name and location
            string myName = "Valerie";
            string mylocation = "Rexburg";

            //Output name and location with labels
            Console.WriteLine($"My name is {myName}.");
            Console.WriteLine($"I am from {mylocation}.");

            //Output the current date
            Console.WriteLine($"Today's date is {DateTime.Now:MM/dd/yyyy}");

            //Calculate and output days until Christmas
            DateTime today = DateTime.Today;
            DateTime christmas = new DateTime(today.Year, 12, 25);
            int daysTilChristmas = (christmas - today).Days;
            Console.WriteLine($"Days until Christmas: {daysTilChristmas}");

            //Example program from C# Programming Yellow Book (Section 2.1) with labels and added requirements
            Console.WriteLine("Example program output:");
            double width, height, woodLength, glassArea;
            Console.Write("Enter the width of the window (meters): ");
            width = double.Parse(Console.ReadLine());
            Console.Write("Enter the height of the window (meters): ");
            height = double.Parse(Console.ReadLine());

            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);

            Console.WriteLine($"The length of the wood is {woodLength} feet.");
            Console.WriteLine($"The area of the glass is {glassArea} square meters.");

            //Pause the console
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
