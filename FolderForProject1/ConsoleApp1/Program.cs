namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello. What's your name?");
            var userInput = Console.ReadLine();
            Console.WriteLine("What's your surname?");
            var surname = Console.ReadLine();
            Console.WriteLine("How old are you?");
            var age = Console.ReadLine();
            Console.WriteLine("What's your profession?");
            var profession = Console.ReadLine();
        }
    }
}
