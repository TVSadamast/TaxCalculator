using System;

namespace TaxCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            double salary;
            string repeat;

            do
            {
                Console.WriteLine("\nTax Calculator");

                try
                {
                    Console.Write("Please enter your Age : ");
                    age = int.Parse(Console.ReadLine());

                    Console.Write("Please enter your Salary : ");
                    salary = int.Parse(Console.ReadLine());

                    TaxCalculator taxCalculator = new TaxCalculator(age, salary);
                    taxCalculator.CalculateTax();
                    Console.WriteLine("Total Payable Tax : " + taxCalculator._tax);

                    Console.WriteLine("\nDo you want to Calculate Tax again?(Y/N)");
                    repeat = Console.ReadLine();
                }
                catch (FormatException)
                {
                    Console.WriteLine("**Please enter valid data.");
                    repeat = "Y";
                }              

            } while (repeat == "Y" || repeat == "y");
        }
    }
}
