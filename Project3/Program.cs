using Microsoft.VisualBasic;

namespace Project3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hello. What's your year of birth?");
            var userInput = Console.ReadLine();
            int yearOfBirth = Convert.ToInt32(userInput);
            Console.Write($"Your age is {2024 - yearOfBirth}");
        }
    }
}
