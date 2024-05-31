namespace Project2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hello. What's your name? ");
            var userInput = Console.ReadLine();
            Console.Write($"Your name is {userInput}.");
            Console.Write("What's your surname?");
            var surname = Console.ReadLine();
            Console.Write($"Your surname is {surname}.");
            Console.Write("How old are you?");
            var age = Console.ReadLine();
            Console.Write($"You are {age}.");
            Console.Write("What's your profession?");
            var profession = Console.ReadLine();
            string profWrite = $"You are {profession}";
            Console.Write($"You are {profession}.");
        }

    }
}
