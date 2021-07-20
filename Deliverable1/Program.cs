using System;

namespace Deliverable1
{
    class program
    {
        static void Main(string[] args)
        {
            string answer = "Yes";

            do
            {
                Console.Write("Please enter a measurement type: ");
                string measurement = Console.ReadLine();

                Console.Write("Please enter an amount: ");
                double amount = double.Parse(Console.ReadLine());

                if (measurement == "inch")
                {
                    double InchConversion = amount * 3.5;
                    Console.WriteLine("The conversion is: " + InchConversion + " fidget spinners");
                }
                else if (measurement == "fidget spinners")
                {
                    double FSConversion = amount / 3.5;
                    Console.WriteLine("The conversion is: " + FSConversion + " inch");
                }
                else if (measurement == "foot")
                {
                    double FConversion = amount * 5;
                    Console.WriteLine("The conversion is: " + FConversion + " memes");
                }
                else if (measurement == "memes")
                {
                    double MConversion = amount / 5;
                    Console.WriteLine("The conversion is: " + MConversion + " foot");
                }

                Console.WriteLine("Would you like to do another calculation? Enter yes to continue or press any key to exit.");
                answer = Console.ReadLine();

            } while (answer == "yes");
        }
    }
}