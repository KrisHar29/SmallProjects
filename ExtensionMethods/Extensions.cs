using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    public static class Extensions
    {
        public static void Print(this string input)
        {
            Console.WriteLine(input);
        }

        public static string Excite(this string input) 
        {
            return input.Replace('.', '!'); 
        }

        public static PersonModel Fill(this PersonModel input) 
        {
            Console.Write("Enter your first name: ");
            input.FirstName = Console.ReadLine();

            Console.Write("Enter your last name: ");
            input.LastName = Console.ReadLine();

            Console.Write("Enter your age: ");
            input.Age = Convert.ToInt32(Console.ReadLine());

            return input;
        }

        public static PersonModel Print(this PersonModel input)
        {
            Console.WriteLine($"{ input.FirstName } { input.LastName } is { input.Age } years old.");
            return input;
        }

        public static double Add(this double input, double x)
        {
            input = input + x;
            return input;
        }

        public static double Subtract(this double input, double x)
        {
            input = input - x;
            return input;
        }

        public static double Multiply(this double input, double x)
        {
            input = input * x;
            return input;
        }

        public static double Divide(this double input, double x)
        {
            input = input / x;
            return input;
        }
    }

}
