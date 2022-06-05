// https://www.codecademy.com/courses/learn-c-sharp/projects/csharp-money-maker-live
using System;

namespace MoneyMaker
{
    class BlaBla
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Money Maker!");
            // Q2
            Console.WriteLine("Enter an amount to convert to coins:");

            // Q6
            string quarterString = "A quarter is worth 25 cents";
            string dimeString = "A dime is worth 10 cents";
            string nickleString = "A nickel coin is worth 5 cents";
            string pennyString = "A penny coin is worth 1 cent";
            Console.WriteLine(quarterString);
            Console.WriteLine(dimeString);
            Console.WriteLine(nickleString);
            Console.WriteLine(pennyString);
            // Q2
            Console.WriteLine();
            string totalAsString = Console.ReadLine();
            // Q3 & Q12 for -> Math.Round
            double totalDouble = Math.Round(Convert.ToDouble(totalAsString));
            // Math.Round(double.TryParse(totalAsString, out totalDouble));

            // or use Convert.ToDouble(); but I'll stay consistant with int32.TryParse or double.TryParse for now the TryParse(string, out double); FOR Q12 we had to use Convert.ToDouble() to use Math.Round(...);

            // Q4
            Console.WriteLine($"{totalAsString} cents is equal to...");
            Console.WriteLine();
            int dimeValue = 10;
            int nickleValue = 5;

            // Q12 quarters
            int quarterValue = 25;

            // Q12 introducing quarters to the mix!
            double quarters = Math.Floor(totalDouble / quarterValue);
            double remainder = totalDouble % quarterValue;

            // Q7
            double dimes = Math.Floor(remainder / dimeValue);

            // Q8
            double pennies = remainder % dimeValue;

            // Q9
            double nickles = Math.Floor(pennies / nickleValue);

            // Q10
            pennies = pennies % nickleValue;

            Console.WriteLine($"Quarters: {quarters}");
            Console.WriteLine($"Dimes: {dimes}");
            Console.WriteLine($"Nickles: {nickles}");
            Console.WriteLine($"Pennies: {pennies}");
        }
    }
}