using System;

namespace CalculateAgeInYearsAnMonths
{
    class Program
    {
     
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a date and time:");
            Console.Write("Year: ");
            int year = int.Parse(Console.ReadLine());

            Console.Write("Month: ");
            int month = int.Parse(Console.ReadLine());

            Console.Write("Day: ");
            int day = int.Parse(Console.ReadLine());

            Console.Write("Hour: ");
            int hour = int.Parse(Console.ReadLine());

            Console.Write("Minute: ");
            int minute = int.Parse(Console.ReadLine());

            Console.Write("Second: ");
            int second = int.Parse(Console.ReadLine());

            // Creating DateTime Object with User Inputs 
            DateTime userInput = new DateTime(year, month, day, hour, minute, second);

            //Creating Instance for Calculate age class
            CalculateAge calculateAge = new CalculateAge(userInput);

            //Calculate Age After calling the function of class
            var result = calculateAge.CalculateAgeFunc();

            //printing the Age in Number Of Years ,Number of Months ,Number of Days 
            Console.WriteLine($"Dear User You Are : {result}  Old");
        }
    }
}
